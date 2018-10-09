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

        private static Movie[] GetSeedMovies(bool seed)
        {
            if (!seed)
                return new Movie[0];

            var movies = new Movie[2];
            movies[0] = new Movie();
            movies[0].Name = "Dunkirk";
            movies[0].RunLength = 123;
            movies[0].ReleaseYear = 2016;
                 
            movies[1] = new Movie();
            movies[1].Name = "Star Wars: A New Hope";
            movies[1].RunLength = 125;
            movies[1].ReleaseYear = 1977;

            return movies;
        }

        public MovieDatabase(bool seed) : this(GetSeedMovies(seed))
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

        public MovieDatabase(Movie[] movies)
        {
            for (var index = 0; index < movies.Length; ++index)
                _movies[index] = movies[index];
        }

        public void Add(Movie movie)
        {
            var index = FindNextFreeIndex();

            if (index >= 0)
                _movies[index] = movie;

        }

        private int FindNextFreeIndex()
        {
            for (var index = 0; index < _movies.Length; ++index)
            {
                if (_movies[index] == null)
                    return index;
            };

            return -1;
        }

        private Movie[] _movies = new Movie[100];

        public Movie[] GetAll()
        {
            var count = 0;
            foreach(var movie in _movies)
            {
                if(movie != null)
                {
                    ++count;
                }
            };

            var temp = new Movie[count];

            var index = 0;
            foreach (var movie in _movies)
            {
                if (movie != null)
                {
                    temp[index++] = movie;
                }
            };

            return temp;
        }

        public void Remove(string name)
        {
            for(var index = 0; index < _movies.Length; ++index)
            {
                if(String.Compare(name, _movies[index].Name, true) == 0)
                {
                    _movies[index] = null;
                    return;
                };
            };
        }

        public void Edit( string name, Movie movie )
        {
            //find movie by name
            Remove(name);

            //replace it
            Add(movie);
        }
    }
}
