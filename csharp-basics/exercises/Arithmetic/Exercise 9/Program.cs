using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight!");
            double personWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height!");
            double personHeight = double.Parse(Console.ReadLine());
            double convertPoundToKg = 2.20462 * personWeight;
            double convertInchToCm = 0.393701 * personHeight;
            double calculateBMI = convertPoundToKg  / (convertInchToCm * convertInchToCm) * 703;
            
            if (calculateBMI < 25 && calculateBMI > 18.5)
            {
                Console.WriteLine("Your BMI is optimal!");
            }
            else if (calculateBMI < 18.5)
            {
                Console.WriteLine("Your BMI is smaller than optimal!");
            }
            else
            {
                Console.WriteLine("Your BMI is bigger than optimal!");
            }
        }
    }
}
