using System;
using System.CodeDom;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");
            
            var input = Console.ReadLine();
            long n = 0;
            
            if( long.TryParse(input, out n))
            {
                if (n < 0)
                {
                    n *= -1;
                }

                if (n >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int digits = 1;
                    switch (n.ToString().Length)
                    {
                        case 2:
                            digits = 2;
                            break;
                        case 3:
                            digits = 3;
                            break;
                        case 4:
                            digits = 4;
                            break;
                        case 5:
                            digits = 5;
                            break;
                        case 6:
                            digits = 6;
                            break;
                        case 7:
                            digits = 7;
                            break;
                        case 8:
                            digits = 8;
                            break;
                        case 9:
                            digits = 9;
                            break;
                        case 10:
                            digits = 10;
                            break;
                    }
                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }
        }
    }
}