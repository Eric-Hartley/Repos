using System.Net.Http.Headers;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();

            //int sum = Add(2, 2);
            //Console.WriteLine(sum); 

            //int difference = Subtract(2, 10);
            //Console.WriteLine(difference);

            //int product = Multiply(5, 5);
            //Console.WriteLine(product);

            //int quotient = Divide(100, 20);
            //Console.WriteLine(quotient);

            int result = Summation(5, 5, 10, 2, -4, 8);
            Console.WriteLine($"Result: {result}");
        }

        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}. What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine($"One day, {userName} was walking through the woods while wearing a {favColor} t-shirt. " +
                $"{userName} was listening to {favBand} when a random {favAnimal} seemed to appear out of nowhere.");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        // challenge
        public static int Summation(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

    }
}
