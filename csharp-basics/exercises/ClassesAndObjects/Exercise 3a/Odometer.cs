namespace Exercise_3a
{
    class Odometer
    {
        public int Mileage;
        public int KmPerLitter = 10;
        public FuelGauge _FuelGauge;

        public Odometer(int mileage, FuelGauge litters)
        {
            Mileage = mileage;
            _FuelGauge = litters;
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
                _FuelGauge.FuelLoss();
            }
        }
    }
}