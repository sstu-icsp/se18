using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThemeUnitTesting.Library;
using Moq;

namespace ThemeUnitTesting
{
    public class FileFakeSettings : IDataFormatterSettings
    {
        public string DateTimeFormat
        {
            get; set;
        }

        public DateTimeOffset GetDateTimeOffset()
        {
            throw new NotImplementedException();
        }
    }

    [TestClass]
    public class DataFormatterTests
    {
        [TestMethod]
        public void Should_Be_Format_yyyyMM()
        {
            var f = new DataFormatter();

            var mock = new Moq.Mock<IDataFormatterSettings>(MockBehavior.Strict);
            mock.SetupProperty(s => s.DateTimeFormat, "yyyyMM");
            IDataFormatterSettings settings = mock.Object;

            Assert.AreEqual(
                DateTime.Now.ToString("yyyyMM"),
                f.GetDateTimeNow(settings));
        }

        [TestMethod]
        public void Should_Be_In_TimeZone()
        {
            var f = new DataFormatter();

            var mock = new Moq.Mock<IDataFormatterSettings>(MockBehavior.Strict);
            mock.SetupProperty(s => s.DateTimeFormat, "yyyyMM");
            mock
                .Setup(s => s.GetDateTimeOffset())
                .Returns(new DateTimeOffset());
            IDataFormatterSettings settings = mock.Object;
        }
    }
}
