using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itse1430.MovieLib;

namespace Itse1430MovieLib
{
    //responsible for managing a collection movie objects
    public abstract class MovieDatabase
    {
        public void Add( Movie movie )
        {
            //TODO: Vakudate
            if (movie == null)
                return;

            AddCore(movie);
        }

        protected abstract void AddCore( Movie movie );

        //private Movie[] _movies = new Movie[100];

        public Movie[] GetAll()
        {
            return GetAllCore();
        }

        protected abstract Movie[] GetAllCore();

        public void Remove( string name )
        {
            //TODO: Validate
            if (String.IsNullOrEmpty(name))
                return;

            RemoveCore(name);
        }

        protected abstract void RemoveCore( string name );

        public void Edit( string name, Movie movie )
        {
            //TODO: Validate
            if (String.IsNullOrEmpty(name))
                return;
            if (movie == null)
                return;

            //find movie by name
            var existing = FindByName(name);
            if (existing == null)
                return;

            EditCore(existing, movie);
        }

        protected abstract Movie FindByName( string name );
        protected abstract void EditCore( Movie oldMovie, Movie newMovie );

    }
}
