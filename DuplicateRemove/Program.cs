using System;
using System.Collections.Generic;

namespace DuplicateRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using HashSet to Remove Duplicate Characters from a String:=>
            Console.Write("Enter a String : ");
            string input = Console.ReadLine();

            string resultString = string.Empty;
            HashSet<char> removeformstring = new HashSet<char>(input);
            foreach (char item in removeformstring)
            {
                resultString = resultString + item;
            }
            Console.WriteLine("After Removing Duplicates : " + resultString);
            Console.ReadLine();




            //DELTE DUPLICATE  STRING from STRING -:=>>
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string result = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!result.Contains(inputString[i]))
                {
                    result = result + input[i];
                }
            }

            Console.WriteLine(resultString);
            Console.ReadKey();
        }
    }
}
