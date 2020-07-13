using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Write the number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0 || num == 1)
            {
                Console.WriteLine(num + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= num / 2; a++)
                {
                    if (num % a == 0)
                    {
                        Console.WriteLine(num + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(num + " is a prime number");
                
            }
        }
    }
}
