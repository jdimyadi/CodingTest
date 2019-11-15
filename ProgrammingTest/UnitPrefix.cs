using System;
namespace ProgrammingTest
{
    internal enum UnitPrefix
    {
        Yocto,
        Zepto,
        Atto,
        Femto,
        Pico,
        Nano,
        Micro,
        Milli,
        Centi,
        Deci,
        Unity,
        Deca,
        Hecto,
        Kilo,
        Mega,
        Giga,
        Tera,
        Peta,
        Exa,
        Zetta,
        Yotta
    }

    internal static class UnitPrefixFactory
    {
        #region UnitPrefix Extension Methods

        internal static double GetDoubleValue(this UnitPrefix prefix)
        {
            return prefix switch
            {
                UnitPrefix.Yocto => 1e-24,
                UnitPrefix.Zepto => 1e-21,
                UnitPrefix.Atto => 1e-18,
                UnitPrefix.Femto => 1e-15,
                UnitPrefix.Pico => 1e-12,
                UnitPrefix.Nano => 1e-9,
                UnitPrefix.Micro => 1e-6,
                UnitPrefix.Milli => 1e-3,
                UnitPrefix.Centi => 1e-2,
                UnitPrefix.Deci => 1e-1,
                UnitPrefix.Unity => 1,
                UnitPrefix.Deca => 1e1,
                UnitPrefix.Hecto => 1e2,
                UnitPrefix.Kilo => 1e3,
                UnitPrefix.Mega => 1e6,
                UnitPrefix.Giga => 1e9,
                UnitPrefix.Tera => 1e12,
                UnitPrefix.Peta => 1e15,
                UnitPrefix.Exa => 1e18,
                UnitPrefix.Zetta => 1e21,
                UnitPrefix.Yotta => 1e24,
                _ => 1,
            };
        }

        #endregion
    }
}

