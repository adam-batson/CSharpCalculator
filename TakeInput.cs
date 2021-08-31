using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class TakeInput
    {
        /*
        This class takes an ordinal number and asks for that number in a series,
        which it returns.

        It will not accept input that can't be stored as a decimal.
        */
        public static decimal GetNumber(string times)
        {
            Console.WriteLine($"Enter {times} number: ");
            var input = Console.ReadLine();
            decimal number;
            while (!Decimal.TryParse(input, out number))
            {
                Console.WriteLine("Input needs to be an integer or decimal\nEnter a number: ");
                input = Console.ReadLine();
            }

            return number;
        }
    }
}
