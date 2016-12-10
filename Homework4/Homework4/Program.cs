using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Looping: Write a program that calculates factorial of an integer n given by the user.  Please enter a small integer.
            //Asignment #3

            double fact = 1;
            Console.Write("Please enter a number to calculate its factorial: ");
            string strnum = Console.ReadLine();
            int n = int.Parse(strnum);

            for (int i = 1; i <= n; i++)
            {

                fact = i * fact;
                Console.WriteLine("{0}! = {1}", i, fact);
            }
            Console.ReadLine();
        }
    }
}
