using System;
namespace ProgrammingTest
{
    internal enum UnitKind
    {
        Second, Minute, Hour, Day,
        Metre, AstronomicalUnit,
        AngelDegree, AngleSecond, AngleMinute,
        Hectare,
        Litre,
        Gram, Tonne, Dalton,
        Ampere, ElectronVolt,
        Kelvin, Celsius,
        Mole, Candela, Decibel, Bel, Neper,
        Radian,
        Steradian,
        Hertz,
        Newton,
        Pascal,
        Joule,
        Watt,
        Coulomb,
        Volt,
        Farad,
        Ohm,
        Siemens,
        Weber,
        Tesla,
        Henry,
        Lumen,
        Lux,
        Becquerel,
        Gray,
        Sievert,
        Katal
    }

    internal static class UnitKindExtensions
    {
        internal static string Symbol(this UnitKind kind)
        {
            return kind switch
            {
                UnitKind.Second => "s",
                UnitKind.Minute => "min",
                UnitKind.Hour => "h",
                UnitKind.Day => "day",
                UnitKind.Metre => "m",
                UnitKind.AstronomicalUnit => "au",
                UnitKind.AngelDegree => "deg",
                UnitKind.AngleMinute => "min",
                UnitKind.AngleSecond => "sec",
                UnitKind.Hectare => "ha",
                UnitKind.Litre => "l",
                UnitKind.Gram => "g",
                UnitKind.Tonne => "t",
                UnitKind.Dalton => "Da",
                UnitKind.Ampere => "A",
                UnitKind.ElectronVolt => "eV",
                UnitKind.Kelvin => "K",
                UnitKind.Celsius => "degC",
                UnitKind.Mole => "mol",
                UnitKind.Candela => "cd",
                UnitKind.Decibel => "dB",
                UnitKind.Bel => "B",
                UnitKind.Neper => "Np",
                UnitKind.Radian => "rad",
                UnitKind.Steradian => "sr",
                UnitKind.Hertz => "Hz",
                UnitKind.Newton => "N",
                UnitKind.Pascal => "Pa",
                UnitKind.Joule => "J",
                UnitKind.Watt => "W",
                UnitKind.Coulomb => "C",
                UnitKind.Volt => "V",
                UnitKind.Farad => "F",
                UnitKind.Ohm => "Ω",
                UnitKind.Siemens => "S",
                UnitKind.Weber => "Wb",
                UnitKind.Tesla => "T",
                UnitKind.Henry => "H",
                UnitKind.Lumen => "lm",
                UnitKind.Lux => "lx",
                UnitKind.Becquerel => "Bq",
                UnitKind.Gray => "Gy",
                UnitKind.Sievert => "Sv",
                UnitKind.Katal => "kat",
                _ => "INVALID"
            };
        }
    }
}
