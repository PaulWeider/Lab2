using System;

namespace Lab3
{
    internal class Lab3Ex1
    {
        /*
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
        */

        static void Init(double x, double y)
        {
            if (y >= -x && x <= 1 && y <= 1)
            {
                Console.WriteLine("This point is placed inside the figure 1!");
            }
            else
            {
                Console.WriteLine("This point is placed outside the figure 1!");
            }            
        }
    }
}