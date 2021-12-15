namespace Firm
{
    public class CommissionGuy : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public CommissionGuy(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _totalSales = 0;
            _commissionRate = commissionRate;
        }

        public void TotalSalesBonus(double totalSales)
        {
            _totalSales = totalSales * _commissionRate;
        }

        public override double Pay()
        {
            var payment = base.Pay() + _totalSales;
            _totalSales = 0;
            return payment;
        }

        public new string ToString()
        {
            var result = base.ToString();
            result += "\nCurrent hours: " + HoursWorked;
            return result;
        }
    }
}