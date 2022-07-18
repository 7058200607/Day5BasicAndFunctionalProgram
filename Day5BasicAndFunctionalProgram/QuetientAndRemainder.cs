using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicAndFunctionalProgram
{
    public class QuetientAndRemainder
    {
        public static void AQuotientAndRemainder()
        {
            //declare and initialize character variable
            int a = 21, b = 5;
            int q, r;

            //find the quotient
            q = a / b;
            //find the remainder
            r = a % b;

            // display result
            Console.WriteLine("When " + a + " is divided by " + b + ", quotient is " + q + " and remainder is " + r + ".");
        }

    }



}

