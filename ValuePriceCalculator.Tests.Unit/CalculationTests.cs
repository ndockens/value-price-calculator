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
            var valueToClient = 100000;
            var consultantDesperationLevel = 1;
            var calculator = new Calculator();

            List<double> priceOptions = calculator.GetPriceOptions(valueToClient, consultantDesperationLevel);

            Assert.Equal(10000, priceOptions[0]);
            Assert.Equal(15000, priceOptions[1]);
            Assert.Equal(17500, priceOptions[2]);
        }

        [Fact]
        public void ConsultantIsNotDesperate()
        {
            var valueToClient = 100000;
            var consultantDesperationLevel = 0;
            var calculator = new Calculator();

            List<double> priceOptions = calculator.GetPriceOptions(valueToClient, consultantDesperationLevel);

            Assert.Equal(10000, priceOptions[0]);
            Assert.Equal(22000, priceOptions[1]);
            Assert.Equal(50000, priceOptions[2]);
        }
    }
}
