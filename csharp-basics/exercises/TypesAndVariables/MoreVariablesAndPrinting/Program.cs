using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CONVERTION_INCHES_TO_CM = 2.54;
            const double CONVERTION_POUNDS_TO_KG = 0.453592; 
            string name = "Zed A. Shaw"; 
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";
            int age = 35;
            double heightInInches = 74;
            double weightInPounds = 180;
            double heightInCm = Math.Round((CONVERTION_INCHES_TO_CM * heightInInches), 2);
            double weightInKg = Math.Round((CONVERTION_POUNDS_TO_KG * weightInPounds), 2);
           
            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightInCm + " centimeters tall.");
            Console.WriteLine("He's " + weightInKg + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + age + ", " + heightInCm + ", and " + weightInKg
                              + " I get " + (age + heightInCm + weightInKg) + ".");

            Console.ReadKey();
        }
    }
}