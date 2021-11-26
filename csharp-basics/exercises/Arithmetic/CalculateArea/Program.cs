using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMenu();
        }

        public static int GetMenu()
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey().KeyChar.ToString();
            int userChoice = int.Parse(keyboard);

            if (userChoice == 1)
            {
                CalculateCircleArea();
            }
            else if (userChoice == 2)
            {
                CalculateRectangleArea();
            }
            else if (userChoice == 3)
            {
                CalculateTriangleArea();
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("Quit");
            }
            
            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("\nWhat is the circle's radius? ");
            decimal radius = decimal.Parse(Console.ReadLine());

            decimal circleArea = (decimal)Math.PI * radius * 2;
            
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            Console.WriteLine("\nEnter length? ");
            length = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter width? ");
            width = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            Console.WriteLine("\nEnter length of the triangle's base? ");
            ground = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter triangle's height? ");
            height = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}
