using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areaofacircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle

            //input and conversion
            Console.Write("Please enter radius: ");
            double rad = double.Parse(Console.ReadLine());
            //Calculate perimeter
            double perimeter = 2 * 3.14 * rad;
            Console.WriteLine("The perimeter is: {0:F2} ", perimeter);
            Console.ReadLine();

        }
    }
}
