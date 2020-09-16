using System;

namespace Lab2
{
    internal class Lab2Ex1
    {
        /*public static void Main(string[] args)
        {
            int pointX, pointY;

            Console.WriteLine("Input x coord of M point: ");

            pointX = int.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.WriteLine("Input y coord of M point: ");

            pointY = int.Parse(Console.ReadLine() ?? string.Empty);
            
            Init(pointX, pointY);
            Console.ReadKey();
        }*/

        static void Init(int x, int y)
        {
            if (x != 0)
            {
                if (y != 0)
                {
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("The point is placed inside the first coordinate quarter!");
                    } else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("The point is placed inside the second coordinate quarter!");
                    } else if (x > 0 && y < 0)
                    {
                        Console.WriteLine("The point is placed inside the fourth coordinate quarter!");
                    } else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("The point is placed inside the third coordinate quarter!");
                    }
                }
                else
                {
                    Console.WriteLine("The point is placed below the X-Axis!");
                }
            } else if (y == 0)
            {
                Console.WriteLine("The point in the coordinates center!");
            }
            else
            {
                Console.WriteLine("The point is placed below the Y-Axis!");
            }
        }
    }
}