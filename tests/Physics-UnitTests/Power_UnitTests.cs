using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace Aftertime.Concepts.Physics
{
    public sealed class Power_UnitTests
    {
        [Fact]
        void Power__FromWatts__Succeds()
        {
            //  Prepare
            double valueInWatts = 100;

            //  Pre-validate

            //  Perform
            Power power = Power.FromWatts(valueInWatts);
            //  Post-validate

        }
    }
}
