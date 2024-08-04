using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MyCompany.MyProduct.System
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("How many numbers?: ");
            int range = Int32.Parse(Console.ReadLine());

            //first list to get the numbers
            List<int> numbers = new List<int>(range);

            //Second list to store the values
            List<int> values = new List<int>();

            /*  Iterates through list range amount of times to get
                the amount of numbers in the list
            */
            for (int i = 1; i < (range + 1); i++)
            {
                numbers.Add(i);
                
            }
            /*  Going through the list and replacing the spots for the numbers
            */
            foreach (int i in numbers)
            {
                Console.Write($"Number {i}: ");
                var value = Int32.Parse(Console.ReadLine());
                values.Add(value);

            }

            //Enumerating the sum of all the values
            var sum = values.Sum();

            

            

            

            Console.WriteLine(sum);
            
            
        }

        /*Function for adding the numbers
         */
        
    }

    
}
