using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            // Repeat 100 times
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"I've eaten {i} pizza(s)");
            }

            // Repeat until the user says "Yes"
            bool areWeNearlyThereYet = false;
            while(areWeNearlyThereYet == false)
            {
                Console.WriteLine("Are we nearly there yet?");
                areWeNearlyThereYet = Console.ReadLine().ToLower() == "yes";
            }
        }
    }
}
