using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace Aftertime.Concepts.Physics
{
    public sealed class Power_CrossTests
    {
        [Fact]
        public void Power__FromWatts__then__ToWatts__gives_original_value()
        {
            //  Prepare
            double valueInWatts = 1000;

            //  Pre-validate

            //  Perform
            Power power = Power.FromWatts(valueInWatts);
            double newValueInWatts = power.ToWatts();

            //  Post-validate
            Assert.Equal(valueInWatts, newValueInWatts);
        }

        [Fact]
        void Power__FromWatts__then__ToUnitsString_1__returns_string_in_watts()
        {
            //  Prepare
            double valueInWatts = 100;

            //  Pre-validate

            //  Perform
            Power value = Power.FromWatts(valueInWatts);
            string powerAsString = value.ToUnitsString();

            //  Post-validate
            Assert.Equal($"{valueInWatts} W", powerAsString);
        }
    }
}
