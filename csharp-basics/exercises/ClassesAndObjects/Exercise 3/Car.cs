using System;

namespace Exercise_3
{
    class Car
    {
        private static string _name;
        public static bool CarIsMoving = true;

        public Car(string name, int mileage, int liters)
        {
            _name = name;
            Odometer.CurrentMileage = mileage;
            FuelGauge.Currentliters = liters;
        }

        public static void CarMoves()
        {
            Odometer.Mileage();
            FuelGauge.CarRuns();
            Odometer.FuelLoss();
        }

        public static void CarFills()
        {
            FuelGauge.FillUp();
        }
    }
}