using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day5BasicAndFunctionalProgram
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A Choice :");
            Console.WriteLine("0.Flip the Coin Program");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    FlipCoin.AFlipCoin();
                    break;
               


            }
        }
    }
}