//Daniel Clement
//ITSE 1430
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        private void OnAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Daniel Clement\nITSE 1430\nCharacter Creator", "About");
        }

        private void OnNewChacter(object sender, EventArgs e)
        {
            var form = new CharacterForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)//'this' makes the main window the parent of the new form
                return;

            //add to database and refresh
            _database.Add(form.Character);
            RefreshScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _lbCharacters.DisplayMember = "Name";
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            var characters = _database.GetAll();

            _lbCharacters.Items.Clear();
            _lbCharacters.Items.AddRange(characters);
        }

        private CharacterDatabase _database = new CharacterDatabase();

        private void OnCharacterEdit(object sender, EventArgs e)
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            //Show form with selected movie
            var form = new CharacterForm();
            form.Character = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            //Update database and refresh
            _database.Edit(item.Name, form.Character);
            RefreshScreen();
        }

        private void OnCharacterDelete(object sender, EventArgs e)
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            _database.Remove(item.Name);
            RefreshScreen();
        }

        private Character GetSelectedCharacter()
        {
            return _lbCharacters.SelectedItem as Character;
        }
    }
}
