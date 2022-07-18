using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicAndFunctionalProgram
{
    public class PowerOfTwo
    {
        public void ApowerOfTwo()
        {
            Console.WriteLine("Eneter A Number Between 0 And 31 :");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (0 <= Num && Num < 31)
            {
                for (int i = 0; i < Num; i++)
                {
                    Console.WriteLine("2 ^ {0} ={1}", i, Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Given input is not in between 0 to 31");
            }

        }
    }
}
   
