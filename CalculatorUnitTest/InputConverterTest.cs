using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly CalculatorApp.InputConverter _inputConverter = new CalculatorApp.InputConverter();
        
        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);

        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FailsToConvertInvalidStringInputToDouble()
        {
            string inputNumber = "$";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);

        }

    }
}
