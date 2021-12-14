namespace Firm
{
    public class Manager : Employee
    {
        private double _bonus;

        //-----------------------------------------------------------------
        // Sets up an executive with the specified information.
        //-----------------------------------------------------------------
        public Manager(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _bonus = 0;
        }
        //-----------------------------------------------------------------
        // Awards the specified bonus to this executive.
        //-----------------------------------------------------------------
        public void AwardBonus(double managerBonuss)
        {
            _bonus = managerBonuss;
        }

        public void ComisionFee()
        {

        }

        //-----------------------------------------------------------------
        // Computes and returns the pay for an executive, which is the
        // regular employee payment plus a one-time bonus.
        //-----------------------------------------------------------------
        public override double Pay()
        {
            var payment = base.Pay() + _bonus;
            _bonus = 0;
            return payment;
        }
    }
}