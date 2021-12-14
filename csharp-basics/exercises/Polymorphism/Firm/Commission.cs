namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSalesMade;

        private double _comisionPercent;
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _totalSalesMade = 0;
            _comisionPercent = commissionRate;
        }

        public void EarnCommission()
        {

        }
    }
}