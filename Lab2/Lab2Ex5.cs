using System;

namespace Lab2
{
    public class Lab2Ex5
    {
        /*
        static void Main(string[] args)
        {
            //Right trapezoid, isosceles trapezoid, simple trapezoid 
            int alfa, beta;

            Console.WriteLine("Input the alfa angle value: ");
            
            alfa = int.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.WriteLine("Input the beta angle value: ");
            
            beta = int.Parse(Console.ReadLine() ?? string.Empty);
            
            Init(alfa, beta);
            Console.ReadKey();
        }
        */

        static void Init(int alfa, int beta)
        {
            if (alfa == 90 && beta == 90)
            {
                Console.WriteLine("You obtained the square!");
            }
            else if(alfa == 90 || beta == 90) {
                Console.WriteLine("You obtained the right trapezoid!");
            } else if (alfa == beta)
            {
                Console.WriteLine("You obtained the isosceles trapezoid!");
            }
            else
            {
                Console.WriteLine("You obtained a simple trapezoid!");
            }
        }
    }
}