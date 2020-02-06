using CO453_ClassConsoleApp.Unit4;
using System;

namespace CO453_ClassConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = 7;
            double feet = 7260;

            Console.WriteLine("Eric's Distance Converter");
           
            DistanceConverter converter = new DistanceConverter();
            miles = converter.GetDouble("Miles");
            feet = converter.ToFeet(miles);

            Console.WriteLine("The no. of miles = " + miles);
            Console.WriteLine("The no. of feet = " + feet);

            feet = converter.GetDouble("Feet");
            miles = converter.ToMiles(feet);

            Console.WriteLine("The no. of feet = " + feet);
            Console.WriteLine("The no. of miles = " + miles);
            
        }

    }
}
