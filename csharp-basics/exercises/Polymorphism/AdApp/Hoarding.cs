namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _rate;
        private int _numDays;

        public Hoarding(int fee, int rate, int numDays) : base(fee)
        {
            this._rate = rate;
            this._numDays = numDays;
        }

        public override int Cost()
        {
            return _numDays * _rate + base.Cost();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}