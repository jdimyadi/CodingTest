using System;
namespace ProgrammingTest
{
    public class Measurement
    {
        internal readonly BaseUnit Unit;
        internal double Value { get; private set; }

        public Measurement(BaseUnit unit, double value)
        {
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Convert to the expected unit.
        /// Requirements:
        ///     this.Unit.Kind == expectedUnit.Kind (otherwise return 0)
        ///     For example this.Unit.Kind == Metre, then the expectedUnit.Kind should also be Metre.
        /// </summary>
        /// <param name="expectedUnit">The unit to which the Value should be converted to</param>
        /// <returns>The converted value</returns>
        public double ConvertTo(BaseUnit expectedUnit)
        {
            return 0.0;
        }

        public override string ToString()
        {
            return String.Format("{0:0.000} {1}", Value, Unit);
        }
    }
}
