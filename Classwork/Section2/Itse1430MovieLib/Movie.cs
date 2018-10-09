using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    public class Movie
    {
        //property
        public string Name
        {
            get { return _name ?? ""; } //string get()
            set { _name = value; }  //void set (string value)
        }
        //public string GetName()
        //{

        //    return _name ?? ""; // makes sure there is no null strings null coalescing
        //}
        //public void SetName( string value)
        //{
        //    _name = value;
        //}
        //methods^
        private string _name = "";
        //publice System.String Name; full type and solves name collision


        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        //public string GetDescription()
        //{

        //    return _description ?? "";
        //}
        //public void SetDescription(string value)
        //{
        //    //this._description = value; same outputa as next line
        //    _description = value;
        //}
        private string _description;

        public int ReleaseYear { get; set; } = 1900;    //initializes the backing field


        public int RunLength { get; set; }//uses auto property
        //private int _runLength; not nessacary with auto properties

        //int someValue;
        //private int someValue2;

        //void foo()  //methods are functions in a class
        //{
        //    var x = RunLength;

        //    var isLong = x > 100;

        //    var y = someValue;
        //}

        //mixed access
        public int ID { get; private set; }

        public bool IsColor
        {
            get { return ReleaseYear > 1940; }

        }

        public bool IsOwned { get; set; }
    }
}
