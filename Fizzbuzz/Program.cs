using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;

            for(count = 0; count <= 100; count++)
            {
                if (count == 0)
                {
                    Console.WriteLine(0);
                }
                else if(count % 3 == 0)
                {
                    if(count % 5 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    Console.WriteLine("fizz");
                }
                else if(count % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                    Console.WriteLine(count);
            }
            Console.ReadLine();
        }
    }
}
