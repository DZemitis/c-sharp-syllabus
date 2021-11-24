using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int userNumber = int.Parse(Console.ReadLine());

            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 100);

            if (userNumber > randomNumber)
            {
                Console.WriteLine("Sorry, you are too high. I was thinking of {0}", randomNumber);
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Sorry, you are too low.  I was thinking of {0}", randomNumber);
            }
            else
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
        }
    }
}
