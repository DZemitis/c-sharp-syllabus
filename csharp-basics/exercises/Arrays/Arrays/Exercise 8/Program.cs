using System;
using System.Data;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Exercise_8
{
    class Program
    {
        static void Main()
        {
            string[] words = new string[] {"Codelex", "HelloWorld"};
            var rnd = new Random();
            var secretWord = words[rnd.Next(0, words.Length)];
            var guessable = new string('-', secretWord.Length);
            var misses = string.Empty;
            var missesCounter = 5;

            Console.WriteLine($"Welcome to the game of Hangman! You have {missesCounter} lives to guess the word!\n" +
                              $"Guessing the same letter will result of you getting hanged faster! Be smarter!\n");

            while (guessable.IndexOf('-') != -1)
            {
                Console.WriteLine($"Word: {guessable}");
                Console.WriteLine($"Missed letters: {misses}\n");
                var input = Console.ReadKey();
                var guess = input.KeyChar;
                Console.Write($" was Your guess");
                Console.Clear();
                if (WordContains(secretWord, guess))
                {
                    for (var i = 0; i < secretWord.Length; i++)
                    {
                        if (secretWord.ToLower()[i] == guess)
                        {
                            var sb = new StringBuilder(guessable);
                            sb[i] = secretWord[i];
                            guessable = sb.ToString();
                        }
                    }
                }
                else
                {
                    missesCounter--;
                    misses += guess;
                }

                Console.WriteLine("\nYour Lives = {0}!", missesCounter);
                
                if (guessable.IndexOf('-') == -1)
                {
                    Console.Clear();
                    Console.WriteLine($"Congratulations you have guessed the word: {guessable}!");
                    break;
                }
                else
                {
                    if (missesCounter == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You lost!");
                        break;
                    }
                }
            }

            Console.WriteLine("Would You like to restart the game? y/n");
            var answerAboutRestart = Console.ReadKey().KeyChar.ToString();
            Console.Clear();

            if (answerAboutRestart == "y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Thank You for the game!");
            }
            
            Console.ReadKey();
        }

        public static bool WordContains(string word, char guess)
        {
            return word.ToLower().IndexOf(guess) > -1;
        }
    }
}
