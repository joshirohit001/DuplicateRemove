using System;

namespace SumOfDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //SUM OF DIGIT:=>
            Console.WriteLine("Enter a number to sum up the digits");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            while (Number > 0)
            {
                int Remainder = Number % 10;
                Sum = Sum + Remainder;
                Number = Number / 10;
            }
            Console.WriteLine(Sum);
            Console.ReadLine();
        }
    }
}
