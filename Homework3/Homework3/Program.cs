using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {//Program that takes seconds and converts it into days

            //Variables used

            string strsec;
            double intsec;
            double days;
            double secmin = 60;
            double minhour = 60;
            double hourday = 24;

            //Ask user for input of seconds

            Console.Write("Please introduce number of seconds to be converted into days: ");

            //Take value of user as a string
            strsec = Console.ReadLine();

            //Convert strsec into a numerical value

            intsec = double.Parse(strsec);

            //Convert seconds into days

           days = intsec / (secmin * minhour * hourday);

            //Display result on screen for user

            Console.WriteLine("The amount of days is: {0:F2}", days);

            Console.ReadLine(); //To hold up the console
                        
        }
    }
}
