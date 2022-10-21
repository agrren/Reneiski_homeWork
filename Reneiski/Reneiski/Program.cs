using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reneiski
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Cycle 1 iteration #: " + i);

                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("\tCycle 2 iteration #: " + j);
                }
            }
            
            
        }
    }
}
