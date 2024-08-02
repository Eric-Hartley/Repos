using System.Security.Cryptography.X509Certificates;

namespace MyCompany.MyProduct.System
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Capacity of List: ");
            int range = Int32.Parse(Console.ReadLine());

            List<int> numbers = new List<int>(range);

            for (int i = 0; i < range; i++)
            {
                numbers.Add(i);
            }

            

            foreach (int number in numbers)
            {
                int count = 1;
                Console.WriteLine($"Number {count}: ");
                Int32.Parse(Console.ReadLine());
                numbers.Add(number);
                
                count++;
                
            }

            Console.WriteLine($"Capacity: {numbers.Capacity}");
            
        }
    }

    
}
