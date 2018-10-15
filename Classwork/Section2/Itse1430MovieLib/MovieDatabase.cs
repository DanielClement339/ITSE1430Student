using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itse1430.MovieLib;

namespace Itse1430MovieLib
{
    //responsible for managing a collection movie objects
    public class MovieDatabase
    {
        public MovieDatabase() : this(true)
        {

        }

        private static Movie[] GetSeedMovies( bool seed )
        {
            if (!seed)
                return new Movie[0];

            return new [] {
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
        }

        public MovieDatabase( bool seed ) : this(GetSeedMovies(seed))
        {
            //if(seed)
            //{
            //    var movie = new Movie();
            //    movie.Name = "Dunkirk";
            //    movie.RunLength = 123;
            //    movie.ReleaseYear = 2016;
            //    Add(movie);

            //    movie = new Movie();
            //    movie.Name = "Star Wars: A New Hope";
            //    movie.RunLength = 125;
            //    movie.ReleaseYear = 1977;
            //    Add(movie);
            //}
        }

        public MovieDatabase( Movie[] movies )
        {
            _items.AddRange(movies);
        }

        public void Add( Movie movie )
        {
            _items.Add(movie);
            //var index = FindNextFreeIndex();
            //if (index >= 0)
            //    _movies[index] = movie;

        }

        //private Movie[] _movies = new Movie[100];
        private List<Movie> _items = new List<Movie>();

        public Movie[] GetAll()
        {
            var count = _items.Count;

            var temp = new Movie[count];

            var index = 0;
            foreach (var movie in _items)
            {
                temp[index++] = movie;
            };

            return temp;
        }

        public void Remove( string name )
        {
            var movie = FindMovie(name);
            if (movie != null)
                _items.Remove(movie);
        }

        public void Edit( string name, Movie movie )
        {
            //find movie by name
            Remove(name);

            //replace it
            Add(movie);
        }

        private Movie FindMovie( string name )
        {
            //var pairs = new Dictionary<string, Movie>();



            //for (var index = 0; index < _movies.Length; ++index)
            foreach (var movie in _items)
            {
                if (String.Compare(name, movie.Name, true) == 0)
                {
                    return movie;
                };
            };
            return null;
        }
    }
}
