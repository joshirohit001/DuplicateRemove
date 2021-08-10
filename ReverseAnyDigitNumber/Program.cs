using System;

namespace ReverseAnyDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse the any input digit:-
            Console.WriteLine("Enter a No. to reverse");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();

        }
    }
}
