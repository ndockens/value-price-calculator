using System;
using System.Collections.Generic;

namespace ValuePriceCalculator.Core
{
    public class Calculator
    {
        private readonly List<double> lowDesperationDenominators = new() { 10, 4.545454545454545, 2 };
        private readonly List<double> highDesperationDenominators = new() { 10, 6.666666666666667, 5.714285714285714 };

        public Calculator()
        {
        }

        public List<double> GetPriceOptions(int valueToClient, DesperationLevel consultantDesperationLevel)
        {
            var priceOptions = new List<double>();
            List<double> denominators = GetDenominators(consultantDesperationLevel);

            foreach (var denominator in denominators)
            {
                var price = CalculatePrice(valueToClient, denominator);
                priceOptions.Add(price);
            }

            return priceOptions;
        }

        private List<double> GetDenominators(DesperationLevel consultantDesperationLevel)
        {
            if (consultantDesperationLevel == DesperationLevel.Low)
                return lowDesperationDenominators;
            else
                return highDesperationDenominators;
        }

        private double CalculatePrice(int valueToClient, double denominator)
        {
            return Math.Round(valueToClient / denominator, 2);
        }
    }
}
