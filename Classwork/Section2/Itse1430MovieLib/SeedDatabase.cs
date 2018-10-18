using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itse1430.MovieLib;

namespace Itse1430MovieLib
{
    public static class SeedDatabase
        //static class  makes it where you cant make an instance of a class or it's members
    {
        public static void Seed( MovieDatabase database )
        {
            var movies = new[] {
                new Movie()
                {
                    Name = "Dunkirk",
                    RunLength = 123,
                    ReleaseYear = 2016,
                },

                new Movie()
                {
                    Name = "Star Wars: A New Hope",
                    RunLength = 125,
                    ReleaseYear = 1977,
                },
            };
            Seed(database, movies);
        }

        public static void Seed(MovieDatabase database, Movie[] movies )
        {
            foreach(var movie in movies)
            {
                database.Add(movie);
            }
        }
    }
}
