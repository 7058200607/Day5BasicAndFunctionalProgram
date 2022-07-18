using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicAndFunctionalProgram
{
    public class PrimeFactorization
    {
        public static void APrimeFactorization()
        {
            Console.Write("Enter a (int) Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i, j;
            int count = 0;
            int flag = 0;

            Console.WriteLine("\nPrime factor of {0}: ", num);
            for (i = 2; i < num; i++)
            {
                // check for divisibility
                if (num % i == 0)
                {
                    count = 0;
                    // check for prime number
                    for (j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        flag = 1;
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}