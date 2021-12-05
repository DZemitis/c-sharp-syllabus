namespace Exercise_3
{
    class Odometer
    {
        public static int CurrentMileage;

        public static void Mileage()
        {
               CurrentMileage++;
        }

        public static void FuelLoss()
        {
            if (CurrentMileage == CurrentMileage + 10)
            {
                FuelGauge.Currentliters--;
            }
        }
    }
}