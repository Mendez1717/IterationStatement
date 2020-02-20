using System;

namespace IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interation with For Statement: print 1-10 numbers onto the console
            int i; // to count
            int start = 1;
            int end = 10;
          
          
            int n;
            Console.WriteLine("Enter Integer between 2 and 10: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 1)
            {

                int min = n - 1;
                for (i = start; i <= min; i++)
                {
                    Console.WriteLine("You entered an odd number");
                }
            }
            else
            {
                int max = n + 1;
                for (i = start; i <= max; i++)
                {
                    Console.WriteLine("You entered an even number");
                }
            }
        }
    }
}
