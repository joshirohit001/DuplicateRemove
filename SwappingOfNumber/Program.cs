using System;

namespace SwappingOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //USING * AND /
            int a = 5; 
            int b = 10;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.WriteLine("After swap a= " + a + " b= " + b);


            //Using + and -
            int A = 5; 
            int B = 10;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            A = A + B; //A=15 (5+10)      
            B = A - B; //B=5 (15-10)      
            A = A - B; //A=10 (15-5)   
            Console.WriteLine("After swap a= " + A + " b= " + B);
        }
    }
}
