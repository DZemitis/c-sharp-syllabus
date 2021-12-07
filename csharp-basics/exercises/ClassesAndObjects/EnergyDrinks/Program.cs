﻿using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            var energyDrinkers = CalculateEnergyDrinkers(NumberedSurveyed, PurchasedEnergyDrinks);
            var preferCitrus = CalculatePreferCitrus(energyDrinkers, PreferCitrusDrinks);

            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + energyDrinkers + " bought at least one energy drink");
            Console.WriteLine(preferCitrus + " of those " + "prefer citrus flavored energy drinks.");

        }

        public static double CalculateEnergyDrinkers(double numSurveyed, double purchased)
        {
            return Program.NumberedSurveyed * Program.PurchasedEnergyDrinks;
        }
        public static double CalculatePreferCitrus(double energyDrinkers, double preferCitrus)
        {
            return energyDrinkers * preferCitrus;
        }
    }
}
