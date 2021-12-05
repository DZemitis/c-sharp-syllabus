using System;
using System.Linq;

namespace Exercise_10
{
    class NumberSquare
    {
        private static int _minValue = int.Parse(Console.ReadLine());
        private static int _maxValue = int.Parse(Console.ReadLine());

        public static void Game()
        {
            Console.WriteLine("Enter Min and Max value");
            var array = Enumerable.Range(_minValue, _maxValue).ToArray();

            Console.WriteLine($"Min? {_minValue}");
            Console.WriteLine($"Max? {_maxValue}");
            for (int i = 0; i < array.Length; i++)
            {
                int j = _maxValue;
                int num = i;
                while (j-- > 0)
                {
                    if (num >= array.Length)
                    {
                        num = 0;
                    }

                    Console.Write(array[num++]);
                }

                Console.WriteLine();
            }
        }
    }
}
