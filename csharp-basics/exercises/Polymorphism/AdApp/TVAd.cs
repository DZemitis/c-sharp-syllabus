namespace AdApp
{
    public class TVAd : Advert
    {
        private bool _peekTime;
        private int _addLenghtBySec;
        private int _ratePerSec;

        public TVAd(int fee, int addLenghtBySec, int ratePerSec, bool peekTime) : base(fee)
        {
            _addLenghtBySec = addLenghtBySec;
            _ratePerSec = ratePerSec;
            _peekTime = peekTime;
        }

        public override int Cost()
        {
            if (_peekTime == true)
            {
                return base.Cost() + 2 * (_addLenghtBySec * _ratePerSec);
            }
            else
            {
                return base.Cost() + (_addLenghtBySec * _ratePerSec);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}