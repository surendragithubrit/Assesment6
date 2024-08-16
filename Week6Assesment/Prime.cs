using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Assesment
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Number");
                int num = Convert.ToInt32(Console.ReadLine());
                int fact = 0;
                for (int i = 2; i <= num; i++)
                {
                    if (num % 2 == 0)
                    {
                        fact = fact + 1;
                    }
                }
                if (fact == 0)
                {
                    Console.WriteLine("Prime number");
                }
                else
                {
                    Console.WriteLine("Not a prime");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        }

    }

