using System;
using System.Globalization;
using static System.Math;
namespace Lab2
{
    public class Lab2Ex12
    {
        static void Main(string[] args)
        {
            double center1X, center2X, center1Y, center2Y, radius1, radius2;

            Console.WriteLine("Input center1X value: ");

            center1X = double.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.WriteLine("Input center2X value: ");
            
            center2X = double.Parse(Console.ReadLine() ?? string.Empty);
 
            
            Console.WriteLine("Input center1Y value: ");
            
            center1Y = double.Parse(Console.ReadLine() ?? string.Empty);
            
            
            Console.WriteLine("Input center2Y value: ");
            
            center2Y = double.Parse(Console.ReadLine() ?? string.Empty);
            
            
            Console.WriteLine("Input radius1 value: ");
            
            radius1 = double.Parse(Console.ReadLine() ?? string.Empty);
            
            
            Console.WriteLine("Input radius2 value: ");
            
            radius2 = double.Parse(Console.ReadLine() ?? string.Empty);
            
            Init(center1X, center2X, center1Y, center2Y, radius1, radius2);
            Console.ReadKey();
        }

        static void Init(double center1X, double center2X, double center1Y, double center2Y, double radius1, double radius2)
        {
            double centerDistance = Sqrt(Pow(center2X - center1X, 2) + Pow(center2Y - center1Y, 2)), radiusSum = radius1 + radius2;

            if (centerDistance > radiusSum)
            {
                Console.WriteLine("The circles don't intersect!");
            } else if(centerDistance == radiusSum)
            {
                Console.WriteLine("The circles intersect at one point!");
            } else
            {
                Console.WriteLine("The circles intersect at two points!");
            }
        }
    }
}