using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itse1430MovieLib;
using Itse1430MovieLib.Memory;

namespace Itse1430.MovieLib.UI
{
    public partial class MainForm : Form
    {
        //this method can be overridden in a derive type
        protected virtual void SomeFuction()
        {

        }

        //this method MUST BE defined in a derived type
        //protected abstract void SomeAbstracFunction();

        //override means changing the base method
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //Seed database
            SeedDatabase.Seed(_database);

            _listMovies.DisplayMember = "Name";
            RefreshMovies();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            //aboutToolStripMenuItem
            MessageBox.Show(this,"Sorry", "Help", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
        }

        private void OnMovieAdd( object sender, EventArgs e )
        {
            var form = new MovieForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)//'this' makes the main window the parent of the new form
                return;

            //MessageBox.Show("Adding movie");
            _database.Add(form.Movie);
            //Movie.SetName("");

            RefreshMovies();
        }

        private MovieDatabase _database = new MemoryMovieDatabase();


        private void RefreshMovies()
        {
            var movies = _database.GetAll();

            _listMovies.Items.Clear();
            _listMovies.Items.AddRange(movies);
        }

        private void OnMovieDelete( object sender, EventArgs e )
        {
            DeleteMovie();
        }

        private void OnMovieEdit( object sender, EventArgs e )
        {
            EditMovie();
        }

        private Movie GetSelectedMovie()
        {
            return _listMovies.SelectedItem as Movie;
        }

        private void OnMovieDoubleCLick( object sender, EventArgs e )
        {
            //var control = sender as ListBox;
            //var item = control.SelectedItem as Movie;

            EditMovie();
        }

        private void EditMovie()
        {
            var form = new MovieForm();

            var item = GetSelectedMovie();
            if (item == null)
                return;

            form.Movie = item;

            if (form.ShowDialog(this) == DialogResult.Cancel)//'this' makes the main window the parent of the new form
                return;

            _database.Edit(item.Name, form.Movie);

            RefreshMovies();
        }

        private void OnListKeyUp( object sender, KeyEventArgs e )
        {
            //find the key that is pressed
            if(e.KeyData == Keys.Delete)
            {
                DeleteMovie();
            };
        }

        private void DeleteMovie()
        {
            var item = GetSelectedMovie();
            if (item == null)
                return;

            _database.Remove(item.Name);
            RefreshMovies();

            //TODO: add a message box to confirm deleteion
        }
    }
}
