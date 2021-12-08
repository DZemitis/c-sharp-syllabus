using System;

namespace Exercise_3a
{
    class FuelGauge
    {
        public int CurrentLiters;

        public string ReportCurrentLiters()
        {
            return $"{CurrentLiters}";
        }

        public void FillFuel()
        {
            if (CurrentLiters < 70)
            {
                CurrentLiters++;
            }
        }

        public void FuelLoss()
        {
            if (CurrentLiters > 0)
            {
                CurrentLiters--;
            }
        }

    }
}