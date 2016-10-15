using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to check whether a given number is even or odd.
            Console.Write("Please enter the number to be evaluated: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            { Console.WriteLine("{0} is even", num); }
            else Console.WriteLine("{0} is odd", num);
            Console.ReadLine();
        }
            
    }

}
