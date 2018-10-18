using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itse1430.MovieLib;

namespace Itse1430MovieLib.Memory
{
    //responsible for managing a collection movie objects
    public class MemoryMovieDatabase : MovieDatabase
    {
        protected override void AddCore( Movie movie )
        {
            _items.Add(movie);
            //var index = FindNextFreeIndex();
            //if (index >= 0)
            //    _movies[index] = movie;

        }

        //private Movie[] _movies = new Movie[100];
        private List<Movie> _items = new List<Movie>();

        protected override Movie[] GetAllCore()
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

        protected override void RemoveCore( string name )
        {
            var movie = FindByName(name);
            if (movie != null)
                _items.Remove(movie);
        }

        protected override void EditCore( Movie oldMovie, Movie newMovie )
        {
            //find movie by name
            _items.Remove(oldMovie);

            //Replace it
            _items.Add(newMovie);
        }

        protected override Movie FindByName( string name )
        {
           
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
