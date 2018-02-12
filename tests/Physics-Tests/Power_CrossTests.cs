using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace Aftertime.Concepts.Physics
{
    public sealed class Power_CrossTests
    {
        [Fact]
        public void Power__FromWatts__ToWatts__gives_original_value()
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
    }
}
