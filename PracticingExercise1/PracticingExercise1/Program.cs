using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingExercise1 //Program that takes a number and a width and create a triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for input and convert it to numerical value
            Console.Write("Please enter a number: ");
            String strnum = Console.ReadLine();
            int num = int.Parse(strnum);

            Console.Write("Please enter the width of the triangle: ");
            string strwidth = Console.ReadLine();
            int width = int.Parse(strwidth);

            //Create the triangle
            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(num);

                }
                Console.WriteLine();
                width--;
            }
            Console.ReadLine();                 
        }
    }
}
