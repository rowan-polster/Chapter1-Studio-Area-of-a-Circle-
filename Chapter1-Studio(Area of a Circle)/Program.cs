using System;

namespace Chapter1_Studio_Area_of_a_Circle_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double radius;
            double area;
            double circumference;
            double diameter;
            double mpg;
            double amntOfGas;


            Console.WriteLine("Please enter a radius: ");
            input = Console.ReadLine();

            radius = double.Parse(input);

            Console.WriteLine("Please enter your car's MPG: ");

            input = Console.ReadLine();

            mpg = double.Parse(input);

            area = Math.Round(Math.PI * Math.Pow(radius, 2.0), 2);
            circumference = Math.Round((2 * Math.PI * radius), 2);
            diameter = Math.Round((2 * radius), 2);
            amntOfGas = Math.Round((circumference/mpg), 2);


            Console.WriteLine("The area of a circle of radius " + radius + "is " + area);
            Console.WriteLine("The circumference of a circle of radius " + radius + "is " + circumference);
            Console.WriteLine("The diameter of a circle of radius " + radius + "is " + diameter);
            Console.WriteLine("Amount of gas consumed to drive " + circumference + "is " + amntOfGas);
        }
    }
}
