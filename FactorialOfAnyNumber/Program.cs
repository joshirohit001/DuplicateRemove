using System;

namespace FactorialOfAnyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ////FACTORIAL OF A NUMBER:=>
            
            int factorial = 1;
            Console.Write("Enter any Number for factorial NUMBER :=> ");
            int Number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Number; i++)
            {
                factorial = factorial * i;
            }
            Console.Write("Factorial of " + Number + " is: " + factorial);
        }
    }

}
