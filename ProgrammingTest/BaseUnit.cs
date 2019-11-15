using System;
namespace ProgrammingTest
{
    public class BaseUnit
    {
        internal readonly UnitKind Kind;
        internal readonly UnitPrefix Prefix;
        internal readonly double? Exponent;

        internal bool IsPrefixed => Prefix != UnitPrefix.Unity;

        internal BaseUnit(UnitKind kind, UnitPrefix prefix, double? exponent = null)
        {
            this.Kind = kind;
            this.Prefix = prefix;
            this.Exponent = exponent;
        }

        /// <summary>
        /// Returns a base unit with the prefix removed
        /// </summary>
        /// <returns></returns>
        internal BaseUnit RemovingPrefix()
        {
            return new BaseUnit(Kind, UnitPrefix.Unity, Exponent);
        }

        public override string ToString()
        {
            return (Prefix == UnitPrefix.Unity) ? Kind.ToString() : Prefix.ToString() + " " + Kind.ToString();
        }
    }
}
