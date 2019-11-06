using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine(Constant.InputFirstNumber);
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                
                Console.WriteLine(Constant.InputSecondNumber);
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine(Constant.InputOperator);
                string operation = Console.ReadLine();

                double result = calculatorEngine.CalculateValue(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                // TODO: log messages
                Console.WriteLine(ex.Message);
            }

        }
    }
}
