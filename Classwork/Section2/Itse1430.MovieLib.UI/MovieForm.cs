using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itse1430.MovieLib.UI
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }
        public Movie Movie { get; set; }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel; // used to tell the parent form what was pressed
            Close();
        }

        private void OnSave( object sender, EventArgs e )
        {
            var movie = new Movie();// movie class from the movie.cs file
            //var movie2 = new Movie();
            //var name = movie2.GetName();    

            //name is required
            movie.Name = _txtName.Text; // field 
           // movie.SetName(_txtName.Text); //method
            if (String.IsNullOrEmpty(movie.Name))
                return;

            //description
            movie.Description = _txtDescription.Text;   //property
            //movie.SetDescription(_txtDescription.Text); //method

            //release year is numeric if set
            movie.ReleaseYear = GetInt32(_txtReleaseYear);
            if(movie.ReleaseYear < 0)
                return;

            //run lenght
            movie.RunLength = GetInt32(_txtReleaseYear);
            if(movie.RunLength < 0)
                return;

            movie.IsOwned = _chkOwned.Checked;  //checked == true

            Movie = movie;

            DialogResult = DialogResult.OK;
            Close();
        }

        private int GetInt32(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;

            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }

        private void MovieForm_Load( object sender, EventArgs e )
        {
            if(Movie != null)
            {
                _txtName.Text = Movie.Name;
                _txtDescription.Text = Movie.Description;
                _txtReleaseYear.Text = Movie.ReleaseYear.ToString();
                _txtRunLength.Text = Movie.RunLength.ToString();
                _chkOwned.Checked = Movie.IsOwned;
            };
        }
    }
}
