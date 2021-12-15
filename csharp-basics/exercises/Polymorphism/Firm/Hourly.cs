namespace Firm
{
    public class Hourly : Employee
    {
        protected int HoursWorked;

        public Hourly(string eName, string eAddress, string ePhone, string socSecNumber, double rate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            HoursWorked = 0;

        }

        public void AddHours(int moreHours)
        {
            HoursWorked += moreHours;
        }

        public override double Pay()
        {
            var payment = payRate * HoursWorked;
            HoursWorked = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nCurrent hours: " + HoursWorked;
            return result;
        }
    }
}