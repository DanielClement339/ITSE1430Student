﻿using System;
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

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel; // used to tell the parent form what was pressed
            Close();
        }

        private void OnSave( object sender, EventArgs e )
        {
            var movie = new Movie();

            //name is required
            movie.Name = _txtName.Text;
            if (String.IsNullOrEmpty(_txtName.Text))
                return;

            //description
            movie.Description = _txtDescription.Text;

            //release year is numeric if set
            movie.ReleaseYear = GetInt32(_txtReleaseYear);
            if (movie.ReleaseYear < 0)
                return;

            //run lenght
            movie.RunLength = GetInt32(_txtReleaseYear);
            if (movie.RunLength < 0)
                return;

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
    }
}
