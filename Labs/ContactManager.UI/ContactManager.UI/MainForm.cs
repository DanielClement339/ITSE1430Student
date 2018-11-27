/*
 * ITSE 1430
 * Daniel Clement
 */

using ContactManager.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                        "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        private void OnAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Daniel Clement\nITSE 1430\nCharacter Creator", "About");
        }

        private void OnContactAdd(object sender, EventArgs e)
        {
            var form = new ContactForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

        }

        private void RefreshContacts()
        {
            //OrderBy
            //var movies = _database.GetAll();
            var movies = from m in _database.GetAll()
                         orderby m.Name
                         select m;

            _listContacts.Items.Clear();

            //foreach (var movie in movies)
            //    _listMovies.Items.Add(movie);

            //Use ToArray extension method from LINQ
            _listContacts.Items.AddRange(movies.ToArray());
        }

        private IContactDatabase _database = new MemoryContactDatabase();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _listContacts.DisplayMember = "Name";
            RefreshContacts();
        }
    }
}
