using System;
using System.Collections.Generic;
using System.Text;

namespace Aftertime.Concepts.Physics
{
    public interface IMeasurable
    {
        string ToUnitsString();
    }

    public interface IMeasurable<TUnits>
    {
        string ToUnitsString(TUnits units);
    }
}
