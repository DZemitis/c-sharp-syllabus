using System;

namespace Exercise_3
{
    class FuelGauge
    {
        public static int Currentliters;

        public static void FillUp()
        {
            if (Currentliters != 70)
            {
                Currentliters++;
            }
        }

        public static void CarRuns()
        {
            Currentliters--;
        }
    }
}