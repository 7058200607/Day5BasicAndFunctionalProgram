using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicAndFunctionalProgram
{
    public static class FlipCoin
    {
        public static void AFlipCoin()
        {
            int head = 0;
            int tails = 0;
            int input;


            Console.WriteLine("Enter The number of times to Flip Coin :");
            input = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            if (input > 0)
            {
                for (int i = 0; i < input; i++)
                {

                    if (random.NextDouble() < 0.5)
                    {
                        head++;
                        Console.WriteLine(" Head");
                    }
                    else
                    {
                        Console.WriteLine("Tails");
                        tails++;
                    }
                }
                double Percentage_head = (double)head / input * 100;
                Console.WriteLine("percentage of Head :" + Percentage_head + "%");
                double percentage_tail = (double)tails / input * 100;
                Console.WriteLine("percentage of tail :" + percentage_tail + "%");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }


    }
}

