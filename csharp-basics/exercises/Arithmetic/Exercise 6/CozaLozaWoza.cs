namespace Exercise_6
{
    public class CozaLozaWoza
    {
        private int _number;

        public CozaLozaWoza()
        {
            _number = 110;
        }

        public string PrintCozaLozaWoza()
        {
            var text = string.Empty;
            for (int i = 1; i <= _number; i++)
            {
                if (i % 7 == 0 && i % 5 == 0)
                {
                    text += "WozaLoza ";
                }
                else if (i % 7 == 0 && i % 3 == 0)
                {
                    text += "CozaWoza ";
                }
                else if (i % 5 == 0 && i % 3 == 0)
                {
                    text += "CozaLoza ";
                }
                else if (i % 7 == 0)
                {
                    text += "Woza ";
                }
                else if (i % 5 == 0)
                {
                    text += "Loza ";
                }
                else if (i % 3 == 0)
                {
                    text += "Coza ";
                }
                else
                {
                    text += $"{i} ";
                }

                if (i % 11 == 0)
                {
                    text += "\n";
                }
            }

            return text;
        }
    }
}