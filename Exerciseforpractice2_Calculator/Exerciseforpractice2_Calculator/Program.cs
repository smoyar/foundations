using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciseforpractice2_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input and conversion to numerical values

            Console.Write("Please enter the fisrt number: ");
            double fnum = double.Parse(Console.ReadLine());
            
            Console.Write("Please enter operation: ");
            char oper = Convert.ToChar(Console.ReadLine());

            Console.Write("Please enter second number: ");
            double snum = double.Parse(Console.ReadLine());

            //Perform calculations and display result

            if (oper == '+')
            {
                double result = fnum + snum;
                Console.WriteLine("{0}+{1} = {2}", fnum, snum, result);

            }
            else if (oper == '-')
            {
                double result = fnum - snum;
                Console.WriteLine("{0}-{1} = {2}", fnum, snum, result);

            }
            else if (oper == '/')
            {
                double result = fnum / snum;
                Console.WriteLine("{0}/{1} = {2}", fnum, snum, result);

            }
            else if (oper == '*')
            {
                double result = fnum * snum;
                Console.WriteLine("{0}x{1} = {0}", fnum, snum, result);

            }
            else Console.WriteLine("wrong character");
            Console.ReadLine();
        }
    }
}
