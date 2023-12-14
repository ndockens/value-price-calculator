using System;
using System.Collections.Generic;

namespace ValuePriceCalculator.Core
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public List<double> GetPriceOptions(int valueToClient, int consultantDesperationLevel)
        {
            List<double> denominators = GetDenominators(consultantDesperationLevel);

            double option1 = CalculatePrice(valueToClient, denominators[0]);
            double option2 = CalculatePrice(valueToClient, denominators[1]);
            double option3 = CalculatePrice(valueToClient, denominators[2]);

            return new List<double> { option1, option2, option3 };
        }

        private List<double> GetDenominators(int consultantDesperationLevel)
        {
            if (consultantDesperationLevel == 0)
                return new List<double> { 10, 4.545454545454545, 2 };
            else
                return new List<double> { 10, 6.666666666666667, 5.714285714285714 };
        }

        private double CalculatePrice(int valueToClient, double denominator)
        {
            return Math.Round(valueToClient / denominator, 2);
        }
    }
}
