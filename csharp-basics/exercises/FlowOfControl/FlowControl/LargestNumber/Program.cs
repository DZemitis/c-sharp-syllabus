using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = int.Parse(Console.ReadLine());

            if (input1 > input2)
            {
                if (input1 > input3)
                {
                    Console.WriteLine("Largest number is {0}", input1);
                }
            } 
            else if (input2 > input3)
            {
                Console.WriteLine("Largest numbers is {0}", input2);
            }
            else
            {
                Console.WriteLine("Largest number is {0}", input3);
            }
        }
    }
}
