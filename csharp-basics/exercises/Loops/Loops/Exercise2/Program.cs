using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            var answer = 0;
            Console.WriteLine($"Input number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            for (i = 0; i <= n; i++)
            {
                answer = i * i;
            }

            Console.WriteLine($"{answer}");
            Console.ReadKey();
        }
    }
}