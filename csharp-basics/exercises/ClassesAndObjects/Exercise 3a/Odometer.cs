using System;

namespace Exercise_3a
{
    class Odometer : FuelGauge
    {
        public int Mileage;
        public int KmPerLitter = 10;

        public Odometer(int mileage, int litters)
        {
            Mileage = mileage;
            CurrentLiters = litters;

        }
        public string ReportMileage()
        {
            return $"{Mileage}";
        }

        public void LimitOfOdometer()
        {
            if (Mileage <= 999999)
            {
                Mileage++;
            }
            else
            {
                Mileage = 0;
            }
        }

        public void BurnFuel()
        {
            if (Mileage % KmPerLitter == 0)
            {
                CurrentLiters--;
            }
        }

    }
}