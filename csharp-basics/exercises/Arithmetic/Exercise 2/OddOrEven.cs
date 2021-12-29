namespace Exercise_2
{
    public class OddOrEven
    {
        private int _number;

        public OddOrEven(int number)
        {
            _number = number;
        }

        public string CheckOddOrEven()
        {
            return _number % 2 == 0 ? "Even Number\nbye!" : "Odd Number\nbye!";
        }
    }
}