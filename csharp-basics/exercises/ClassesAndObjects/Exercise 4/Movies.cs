
namespace Exercise_4
{
    class Movie
    {
        public Movie(string title, string studio, string rating)
        {
            _studio = studio;
            _title = title;
            Rating = rating;
        }

        public Movie(string title, string studio)
        {
            _studio = studio;
            _title = title;
            Rating = "PG";
        }

        private string _title { get; set; }
        private string _studio { get; set; }
        public string Rating { get; set; }

        public string Display()
        {
            return $"{_title} {_studio} {Rating}";
        }

        public override string ToString()
        {
            return $"{_title} {_studio} {Rating}";
        }
    }
}