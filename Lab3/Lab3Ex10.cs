using System;
using static System.Math;

namespace Lab3
{
    public class Lab3Ex10
    {
        public static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Input x value: ");

            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input y value: ");
            
            y = Convert.ToDouble(Console.ReadLine());
            
            Init(x, y);
            Console.ReadKey();
        }

        static void Init(double x, double y)
        {
            if (y <= x + 1 && y <= 1 - Pow(x, 2) && y >= 0)
            {
                Console.WriteLine("This point is placed inside the figure 2!");
            }
            else
            {
                Console.WriteLine("This point is placed outside the figure 2!");
            }
        }

    }
}