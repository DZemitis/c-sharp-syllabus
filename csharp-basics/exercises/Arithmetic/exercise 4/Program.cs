using System;

namespace exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum *= i;

            }
            Console.WriteLine(sum);

        }
    }
}
