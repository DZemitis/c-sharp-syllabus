namespace Exercise_3a
{
    class Odometer
    {
        private int _mileage;
        private int _kmPerLitter = 10;
        private FuelGauge _fuelGauge;

        public Odometer(int mileage, FuelGauge litters)
        {
            _mileage = mileage;
            _fuelGauge = litters;
        }
        public string ReportMileage()
        {
            return $"{_mileage}";
        }

        public void LimitOfOdometer()
        {
            if (_mileage <= 999999)
            {
                _mileage++;
            }
            else
            {
                _mileage = 0;
            }
        }

        public void BurnFuel()
        {

            if (_mileage % _kmPerLitter == 0)
            {
                _fuelGauge.FuelLoss();
            }
        }
    }
}