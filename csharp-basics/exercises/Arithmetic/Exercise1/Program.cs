using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CheckIfTrue(5, 20));
        }

        public static bool CheckIfTrue(int n1, int n2)
        {

            if (n1 + n2 == 15 || n2 - n1 == 15 || n1 == 15 || n2 == 15 || n1 - n2 == 15)
            {
                return true;
            }

            return false;
        }
    }
}