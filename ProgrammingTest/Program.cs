using System;

namespace ProgrammingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseUnit cm = new BaseUnit(UnitKind.Metre, UnitPrefix.Centi); //cm
            Measurement measurement = new Measurement(cm, 4.0);

            Console.WriteLine("Converting " + measurement);
            BaseUnit mm = new BaseUnit(UnitKind.Metre, UnitPrefix.Milli);
            double miliValue = measurement.ConvertTo(mm);
            if (miliValue.Equals(40))
            {
                Console.WriteLine(String.Format("{0} => {1} {2} [PASS]", cm, mm, miliValue));
            }
            else
            {
                Console.WriteLine(String.Format("{0} => {1} {2} [FAIL]", cm, mm, miliValue));
            }

            BaseUnit microm = new BaseUnit(UnitKind.Metre, UnitPrefix.Micro);
            double microValue = measurement.ConvertTo(microm);
            if (microValue.Equals(40000))
            {
                Console.WriteLine(String.Format("{0} => {1} {2} [PASS]", cm, microm, microValue));
            }
            else
            {
                Console.WriteLine(String.Format("{0} => {1} {2} [FAIL]", cm, microm, microValue));
            }

            BaseUnit gm = new BaseUnit(UnitKind.Metre, UnitPrefix.Giga);
            double gigaValue = Math.Round(measurement.ConvertTo(gm), 5);
            if (gigaValue.Equals(Math.Round(4e-11, 5)))
            {
                Console.WriteLine(String.Format("{0} => {1} {2} [PASS]", cm, gm, gigaValue));
            } else
            {
                Console.WriteLine(String.Format("{0} => {1} {2} [FAIL]", cm, gm, gigaValue));
            }

            BaseUnit ml = new BaseUnit(UnitKind.Litre, UnitPrefix.Milli);
            double miliLiterValue = measurement.ConvertTo(ml);
            if (miliLiterValue.Equals(0))
            {
                Console.WriteLine(String.Format("{0} => {1} {2} [PASS]", cm, ml, miliLiterValue));
            }
            else
            {
                Console.WriteLine(String.Format("{0} => {1} {2} [FAIL]", cm, ml, miliLiterValue));
            }
        }
    }
}
