using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyObjectInitializer
{
    internal class DateMain
    {
        static void Main(string[] args)
        {
            // Property initializer syntax
            DateAutoIncrementedProp d1 = new DateAutoIncrementedProp();
            d1.Day = 22;   // internally C# calls the set assessor
            d1.Month = "Oct";
            d1.Year = 2024;
            // internally C# calls the get assessor
            Console.WriteLine($"Date is {d1.Day}/ {d1.Month} / {d1.Year}");

            // object initializer syntax

            DateAutoIncrementedProp d2 = new DateAutoIncrementedProp { Day = 23, Month = "Sept", Year = 2024 };
            Console.WriteLine($"Date is {d2.Day}/ {d2.Month} / {d2.Year}");
        }

    }
}
