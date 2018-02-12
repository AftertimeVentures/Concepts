using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace Aftertime.Concepts.Physics
{
    public sealed class Power_UnitTests
    {
        [Theory]
        [InlineData(0.0)]
        [InlineData(1000.0)]
        void Power__FromWatts__NonNegative__Succeds(double valueInWatts)
        {
            //  Prepare

            //  Pre-validate

            //  Perform
            Power power = Power.FromWatts(valueInWatts);
            //  Post-validate

        }

        [Fact]
        void Power__FromWatts__Negative__Fails()
        {
            //  Prepare
            double valueInWatts = -100;

            //  Pre-validate

            //  Perform
            NonNegativeValueExpectedException ex = Assert.Throws<NonNegativeValueExpectedException>(() => Power.FromWatts(valueInWatts));

            //  Post-validate
            Assert.Equal(valueInWatts, ex.Value);
        }

        [Fact]
        public void Power__ToWatts__returnss_0__when_initialized_by_default()
        {
            //  Prepare
            Power value = default(Power);

            //  Pre-validate

            //  Perform
            double valueInWatts = value.ToWatts();

            //  Post-validate
            Assert.Equal(0, valueInWatts);
        }
    }
}
