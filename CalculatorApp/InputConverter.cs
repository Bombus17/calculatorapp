using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException(Constant.InvalidDataInputResponse);
            return convertedNumber;

        }

    }
}
