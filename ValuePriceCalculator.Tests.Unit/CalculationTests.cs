using System.Collections.Generic;
using Xunit;

using ValuePriceCalculator.Core;

namespace ValuePriceCalculator.Tests.Unit
{
    public class CalculationTests
    {
        [Fact]
        public void ConsultantIsDesperate()
        {
            var calculator = new Calculator();

            List<double> priceOptions = calculator.GetPriceOptions(100000, 0);

            Assert.Equal(10000, priceOptions[0]);
            Assert.Equal(15000, priceOptions[1]);
            Assert.Equal(17500, priceOptions[2]);
        }
    }
}
