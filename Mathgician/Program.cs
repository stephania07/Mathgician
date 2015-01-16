using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathgician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I AM THE MATHGICIAN");
            Console.WriteLine("What shall I math?\nFibonacci, primes, or Integers");
            string desiredMaths = Console.ReadLine();
            Console.WriteLine("Ok. I;m gonna do some" + desiredMaths );
            if ("Integers" == desiredMaths)
            {
                PrintIntegers();
            }
            else if ("Fibonacci" == desiredMaths)
            {
                PrintFibonacciSequence();
            }
            else
            {
                Console.WriteLine("Well, Actually... I Lied..");
            }
            Console.WriteLine("Press Any Key To Exit...");
            Console.ReadLine();
        }

        private static void PrintFibonacciSequence()
        {
            //throw new NotImplementedException();
            //1, 1,, 3, 5, 8, 13
            int previous = 0;
            int current = 1;
            while (true)
            {
                Console.WriteLine(current);
                System.Threading.Thread.Sleep(100);
                int newValue = previous + current;
                previous = current;
                current = newValue;
            }
        }

        private static void PrintIntegers()
        {
            //throw new NotImplementedException();
            int nextInteger = 0;
            while (true)
            {
                nextInteger++;
                Console.WriteLine(nextInteger);
            
            }
        }
    }
}
