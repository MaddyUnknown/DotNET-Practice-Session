using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;

namespace D1_Test
{
    [TestClass]
    public class TemperatureTest
    {

        [TestMethod]
        public void TempCelciusToFarenheit_CelciusTemp_FarenheitTemp()
        {
            float celc = 0;
            float expectedFaren = 32;

            float actualFaren = TempetatureUtils.tempCelciusToFarenheit(celc);

            Assert.AreEqual(expectedFaren, actualFaren, 0.0001, "Celcius is not properly converted to Farenheit") ;

        }

        [TestMethod]
        public void TempFarenheitToCelcius_FarenheitTemp_CelciusTemp()
        {
            float faren = -123;
            float expectedCelc = -86.1111f;

            float actualCelc = TempetatureUtils.tempFarenheitToCelcius(faren);

            Assert.AreEqual(expectedCelc, actualCelc, 0.0001, "Farenheit is not properly converted to Celcius");

        }
    }
}
