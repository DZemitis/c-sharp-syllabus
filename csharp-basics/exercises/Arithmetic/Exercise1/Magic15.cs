namespace ConsoleApp8
{
    public class Magic15
    {
        private int _number1;
        private int _number2;

        public Magic15(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public bool CheckIfSumOrNumberIs15()
        {
            var number1 = _number1;
            var number2 = _number2;
            return (number1 + number2 == 15 || number2 - number1 == 15 || number1 == 15 || number2 == 15 ||
                    number1 - number2 == 15);
        }
    }
}