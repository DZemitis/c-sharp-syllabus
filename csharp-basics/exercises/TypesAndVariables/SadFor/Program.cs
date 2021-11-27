using System;

namespace SadFor
{
    class Program
    {
        public static void Main(string[] args)
        {
            Test1();
        }

        public static void Test1()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Math.Sqrt(i) > 2.5)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}