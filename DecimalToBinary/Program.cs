using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONVERT DECIMAL TO BINARY
            int Number;
            int i;
            int[] arryy= new int[10];
            Console.Write("Enter the number to convert: ");
            Number = int.Parse(Console.ReadLine());
            for (i = 0; Number > 0; i++)
            {
                arryy[i] = Number % 2;
                Number = Number / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(arryy[i]);
            }
    }
}
