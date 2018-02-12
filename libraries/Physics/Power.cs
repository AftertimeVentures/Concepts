using System;
using System.Collections.Generic;
using System.Text;

namespace Aftertime.Concepts.Physics
{
    public enum PowerUnits
    {
        Watt,
    }

    public partial struct Power
        : IMeasurable<PowerUnits>
    {
        private Power(double valueInWatts)
        {
            if (valueInWatts < 0)
            {
                throw new NonNegativeValueExpectedException(valueInWatts);
            }

            _valueInWatts = valueInWatts;
        }

        public double ToWatts()
        {
            return _valueInWatts;
        }

        public static Power FromWatts(double value)
        {
            return new Power(value);
        }

        public string ToUnitsString()
        {
            return ToUnitsString(PowerUnits.Watt);
        }
        public string ToUnitsString(PowerUnits units)
        {
            return $"{_valueInWatts} W";
        }


        private double _valueInWatts;
    }
}
