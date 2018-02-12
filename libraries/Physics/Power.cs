using System;
using System.Collections.Generic;
using System.Text;

namespace Aftertime.Concepts.Physics
{
    public partial struct Power
    {
        private Power(double valueInWatts)
        {
            if (valueInWatts < 0)
            {
                throw new NonNegativeValueExpectedException(valueInWatts);
            }

            _valueInWatts = valueInWatts;
        }

        public static Power FromWatts(double value)
        {
            return new Power(value);
        }

        private double _valueInWatts;
    }
}
