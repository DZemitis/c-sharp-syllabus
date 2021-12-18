using System;

namespace Exercise_4
{
    class HappyNumber

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            var Number = int.Parse(Console.ReadLine());
            var result = Number;

            while (result != 1 && result != 4)
            {
                result = IsHappyNumber(result);
            }

            if (result == 1)
            {
                Console.WriteLine(Number + " is a happy number");
            }
            else
            {
                Console.WriteLine(Number + " is not a happy number");
            }

            Console.ReadKey();
        }

        public static int IsHappyNumber(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                var rem = num % 10;
                sum += rem * rem;
                num /= 10;
            }
            return sum;
        }
    }
}
