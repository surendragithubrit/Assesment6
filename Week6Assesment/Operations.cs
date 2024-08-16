using System;
using System.Linq;

namespace Week6Assesment
{
    internal class Operations
    {
        static void Main(string[] args)
        {
            try
            {

                int[] numbers = { 10, 20, 30, 33, 40, 50, 60, 70, 80, 90, 100 };


                int sum = numbers.Sum();
                Console.WriteLine($"Sum is:{sum}");
                double average = numbers.Average();
                Console.WriteLine($"Average is:{average}");
                int max = numbers.Max();
                Console.WriteLine($"Maximum value is : {max}");
                int min = numbers.Min();
                Console.WriteLine($"Minimum value is : {min}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            }
            
    }
}
