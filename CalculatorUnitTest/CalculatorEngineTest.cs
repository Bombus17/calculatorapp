using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorApp.CalculatorEngine _calculatorEngine = new CalculatorApp.CalculatorEngine();


        [TestMethod]
        public void AddsTwoNumberAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.CalculateValue("add", number1, number2);
            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void AddsTwoNumberAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.CalculateValue("+", number1, number2);
            Assert.AreEqual(3, result);

        }
    }
}
