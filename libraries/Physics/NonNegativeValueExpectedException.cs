using System;
using System.Collections.Generic;
using System.Text;

namespace Aftertime.Concepts.Physics
{
    public sealed class NonNegativeValueExpectedException
        : Exception
    {
        public NonNegativeValueExpectedException(double value)
        {
            Value = value;
        }

        public readonly double Value;
    }
}
