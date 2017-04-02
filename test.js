mocha.setup('bdd');
var assert = chai.assert;

describe("checkEmailLength", function() {

    it ("Проверка длинны мыла", function() {
        assert.equal(xxxUnit.checkEmailLength('artik@gmail.com'), true);
    });
    it ("Проверка длинны мыла", function() {
        assert.equal(xxxUnit.checkEmailLength('@gmail.com'), false);
    });
    it ("Проверка длинны мыла", function() {
        assert.equal(xxxUnit.checkEmailLength('sabaka_gmail.com'), false);
    });
    it ("Проверка длинны мыла", function() {
        assert.equal(xxxUnit.checkEmailLength('timur96@'), false);
    });
    it ("Проверка длинны мыла", function() {
        assert.equal(xxxUnit.checkEmailLength(''), false);
    });
    it ("Проверка длинны мыла", function() {
        assert.equal(xxxUnit.checkEmailLength('0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789ffffffffffffffffffffffffff@gmail.com'), false);
    });

});

describe("checkDomainLevel", function() {

    it("Проверка уровня домена ( <2 )", function() {
        assert.equal(xxxUnit.checkDomainLevel('artik@dadam'), true);
    });
    it("Проверка уровня домена ( <2 )", function() {
        assert.equal(xxxUnit.checkDomainLevel('artik@dadam.ru'), true);
    });
    it("Проверка уровня домена ( <2 )", function() {
        assert.equal(xxxUnit.checkDomainLevel('artik@dadam.ru.heh'), false);
    });

});

describe("checkBlackList", function() {

    it("Проверка черного списка", function() {
        assert.equal(xxxUnit.checkBlackList('wtf@yandex.ru'), 'Подозрительно');
    });
    it("Проверка черного списка", function() {
        assert.equal(xxxUnit.checkBlackList('artik@amigo.ru'), 'Подозрительно');
    });
    it("Проверка черного списка", function() {
        assert.equal(xxxUnit.checkBlackList('wtf@amigo.ru'), 'Подозрительно');
    });
    it("Проверка черного списка", function() {
        assert.equal(xxxUnit.checkBlackList('artik@yandex.ru'), true);
    });

});



mocha.run();