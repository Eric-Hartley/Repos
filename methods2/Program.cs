using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MyCompany.MyProduct.System
{
    class Program
    {
        public static void Main(String[] args)
        {
            // enter the amount of numbers here
            int num1;
            int num2;
            int num3;
            int num4;
            int num5;

            // Operation and choosing which numbers
            var result = Add(10, 20);
            var product = Multiply(10, 20);
            var difference = Subtract(10, 20);
            var quotient = Divide(20, 10);


            // Printing the final result of whichever
            Console.WriteLine($"Quotient: {quotient}");
        }
        public static int Add(int num1, int num2)
        { 
            return num1 + num2; 
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
