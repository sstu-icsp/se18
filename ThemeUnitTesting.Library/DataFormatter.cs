using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeUnitTesting.Library
{
    public interface IDataFormatterSettings
    {
        string DateTimeFormat { get; set; }
        DateTimeOffset GetDateTimeOffset();
    }

    /*

        Форматтер.
        1. Возвращать текущую дату/времени с учетом предпочитаемого формата.
        2. Возвращать текущую дату/времени с учетом смещения/пояса.

    */

    public class DataFormatter
    {
        public string GetDateTimeNow(IDataFormatterSettings settings)
        {
            return DateTime.Now.ToString(settings.DateTimeFormat);
        }
    }
}
