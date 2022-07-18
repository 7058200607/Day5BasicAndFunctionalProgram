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
            Console.WriteLine("1.Leap Year Program");
            Console.WriteLine("2.Check the power of 2");
            Console.WriteLine("3.Calculate Harmonic Number");
            Console.WriteLine("4.Calculate  prime Factorization of number");
            Console.WriteLine("5.Find Quotient And Remainder");
            Console.WriteLine("6.Swap A Given Number");
            Console.WriteLine("7.Number is Even Or Odd");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    FlipCoin.AFlipCoin();
                    break;
                case 1:
                    LeapYearOrNot.ALeapYear();
                    break;
                case 2:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.ApowerOfTwo();
                    break;
                case 3:
                    HarmonicFunction harmonicNumber = new HarmonicFunction();
                    harmonicNumber.AHarmonicNumber();
                    break;
                case 4:
                    PrimeFactorization.APrimeFactorization();
                    break;
                case 5:
                    QuetientAndRemainder.AQuotientAndRemainder();
                    break;
                case 6:
                    SwapTwoNumber.ASwapNumber();
                    break;
                case 7:
                    EvenOrOddNumber.AEvenOddNumber();
                    break;

            }
        }
    }
}