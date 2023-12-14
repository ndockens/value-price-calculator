using System.Collections.Generic;

namespace ValuePriceCalculator.Core
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public List<double> GetPriceOptions(int value, int desperationModifier)
        {
            var option1 = value / 10;
            var option2 = value / 6.666666666666667;
            var option3 = value / 5.714285714285714;

            return new List<double>() { option1, option2, option3 };
        }
    }
}
