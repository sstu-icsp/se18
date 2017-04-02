// EmailValidator. Модуль для валидации почтового адреса. Функциональность:
// 5.1. Адрес должен иметь общую длину не более 150 символов.
// 5.2. Домен должен быть максимум второго уровня.
// 5.3. Длина домена должны быть не более 50 символов.
// 5.4. Домен не должен входить в черный список указываемый при валидации.
// 5.5. Домен может быть любого уровня. - WTF !?
// 5.6. Отправитель не должен входить в черный список указываемый при валидации.
// 5.7. Если домен или отправитель входят в черный список, то возвращается результат проверки «Подозрительно».

// mocha.setup('bdd');
// var assert = chai.assert;


var xxxUnit = {

	black_list: {
		email_bl:['wtf', 'kek', 'lol'],
		domain_bl:['rambler.com', 'rambler.ru', 'amigo.ru', 'mail.ru']
	},

	getEmail: () => document.getElementById("get_email_").value,

	notEmpty: function(str) {
		if (str.length != 0 && str.substring(0, str.indexOf('@')).length != 0 && str.indexOf('@') != -1 && str.substring(str.indexOf('@') + 1).length != 0) {
			return true;
		} else {
			console.log('А где?! Пусто!');
			return false;
		}
	},

	checkEmailLength: function(s) {	
		if (this.notEmpty(s)) {
			if (s.length <= 150) {
				console.log('длинна мыла допустимая ^_^');
				return true;
			} else {
				console.log('Недопустимая длинна мыла!!!!!!1111111');
				return false;
				}
		} else return false;
	},

	checkDomainLevel: function(s) {
		if (this.notEmpty(s)) {
				let domain = s.substring(s.indexOf('@') + 1);
				let dots = 0;
				for (let i = 0; i < domain.length; i++) {
					if (domain[i] == '.') {
						dots++;
						if ( dots == 2) {
							console.log('Домен выше второго уровня: ' +domain);
							return false;
						}
					}
				}
				console.log('Домен допустимого уровня ^_^');
				return true;
		} else return false;
	},

	checkBL: function(e, arr) {
		for (let i = 0; i < arr.length; i++) {
			if (e === arr[i]) {
				console.log('Подозрительно! мыло из черного списка!');
				return false;
			}
		}
		return true;
	},

	checkBlackList: function(s) {
		if (this.notEmpty(s)) {
				let domain = s.substring(s.indexOf('@') + 1);
				let email = s.substring(0, s.indexOf('@'));
				if (!this.checkBL(domain, this.black_list.domain_bl) || !this.checkBL(email, this.black_list.email_bl)) {
					return 'Подозрительно';
				} else {
					console.log('Мейлы чисты ^_^');
					return true;
				};
		} else return false;
	},


}
