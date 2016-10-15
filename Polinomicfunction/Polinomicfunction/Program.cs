using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomicfunction
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 
              (using integer numbers for y , ranging from -5 to +5)*/
              for (int y=-5; y<=5;y++)
              {
                double x = y * y + 2 * y + 1;
                Console.WriteLine("Solution for y = {0} is x = {1}", y, x); 
              }
            Console.ReadLine();            
        }
    }
}
