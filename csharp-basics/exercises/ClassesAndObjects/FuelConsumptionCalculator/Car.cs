using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private static double _startKilometers;
        private static double _endKilometers;
        private static double _liters;
        

        public Car(double startOdo, double endingOdo, double liters)
        {
            _startKilometers = startOdo;
            _endKilometers = endingOdo;
            _liters = liters;
        }

        public double CalculateConsumption()
        {
            return ConsumptionPer100Km();
        }

        private double ConsumptionPer100Km()
        {
            return (_liters * 100) / _endKilometers - _startKilometers;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _endKilometers += mileage;
            _liters += liters;
        }
    }
}
