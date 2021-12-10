namespace Exercise_3a
{
    class FuelGauge
    {
        public int CurrentLiters { get; set; }

        public FuelGauge(int liters)
        {
            CurrentLiters = liters;
        }

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