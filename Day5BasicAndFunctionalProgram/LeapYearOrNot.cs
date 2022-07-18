using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicAndFunctionalProgram
{
    public class LeapYearOrNot
    {
        public static void ALeapYear()
        {
            Console.WriteLine("Enter A Number :");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("is a leap year{0}", year);
            }
            else
            {
                Console.WriteLine("is a not a leap year{0}", year);
            }
        }
    }
}

