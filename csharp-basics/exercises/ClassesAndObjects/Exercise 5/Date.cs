namespace Exercise_5
{
    public class Date
    {
        public Date(int month, int day, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public int Month { set; get; }
        public int Day { set; get; }
        public int Year { set; get; }

        public string DisplayDate()
        {
            return $"{Month}/{Day}/{Year}";
        }
    }
}