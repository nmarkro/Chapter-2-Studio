using System;

namespace Chapter_2_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area, circumference, diameter, mpg, gallonsUsed;
            Console.Write("Enter a radius: ");
            radius = double.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(radius, 2);
            circumference = 2 * Math.PI * radius;
            diameter = 2 * radius;
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + diameter);

            Console.Write("Enter your car's miles-per-gallon: ");
            mpg = double.Parse(Console.ReadLine());
            gallonsUsed = circumference / mpg;
            Console.WriteLine("You will use " + gallonsUsed + " gallons of gas driving a circle of radius " + radius + ".");
        }
    }
}
