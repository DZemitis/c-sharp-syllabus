using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int countUpper = 0;
            for (int i = 0; i < userInput.Length -1; i++)
            {
                if (char.IsUpper(userInput[i])) countUpper++;
            }
        }
    }
}
