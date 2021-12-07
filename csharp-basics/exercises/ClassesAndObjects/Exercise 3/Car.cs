using System;

namespace Exercise_3
{
    class Car
    {
        private string _name;
        public bool CarIsMoving = true;

        public Car(string name, int mileage, int liters)
        {
            _name = name;
            Odometer.CurrentMileage = mileage;
            FuelGauge.Currentliters = liters;
        }

        public void CarMoves()
        {
            Odometer.Mileage();
            FuelGauge.CarRuns();
            Odometer.FuelLoss();
        }

        public void CarFills()
        {
            FuelGauge.FillUp();
        }
    }
}