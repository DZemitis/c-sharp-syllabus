using System;
using System.Collections.Generic;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var spiderMan = new Movie("Spider man", "Marvel");
            var glass = new Movie("Glass", "Buena Vista International", "PG13");
            var casinoRoyale = new Movie("Casino Royale", "Eon Production", "PG13");
            var movies = new List<Movie>
            {
                spiderMan,
                glass,
                casinoRoyale
            };

            var filtered = GetPg(movies.ToArray());
            foreach (var movie in filtered)
            {
                Console.WriteLine($"{movie.Display()}");
            }
        }

        public static Movie[] GetPg(Movie[] movies)
        {
            var filtered = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.Rating == "PG")
                {
                    filtered.Add(movie);
                }
            }

            return filtered.ToArray();
        }
    }
}
