using System;

namespace ReverseAnyString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Reverse = "";
            int Length = 0;
            Console.WriteLine("Enter a Word TO REVERSE");
            //Getting String(word) from Console (USER):=>  
            string str = Console.ReadLine();

            //Calculate length of string str  
            Length = str.Length - 1;
            while (Length >= 0)
            {
                Reverse = Reverse + str[Length];
                Length--;
            }
            //Displaying the reverse word  
            Console.WriteLine("Reverse word is {0}", Reverse);
            Console.ReadLine();
        }
    }
}
