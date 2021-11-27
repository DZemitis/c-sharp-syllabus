using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string!");
            string userInput = Console.ReadLine();
            int countUpper = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (char.IsUpper(userInput[i]))
                    countUpper++;
            }

            Console.WriteLine($"Letters written in upper case is {countUpper}");
        }
    }
}
