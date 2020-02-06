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
            feet = converter.ToFeet(miles);

            Console.WriteLine("7 miles in feet = " + feet);

            miles = converter.ToMiles(feet);

            Console.WriteLine("Number of feet from miles " + miles);
        }
    }
}
