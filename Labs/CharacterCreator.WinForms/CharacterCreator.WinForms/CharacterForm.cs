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
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        public Character Character { get; set; }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // used to tell the parent form what was pressed
            Close();
        }



        private void OnSave(object sender, EventArgs e)
        {
            var character = new Character();

            character.Name = _txtName.Text;
            if (String.IsNullOrEmpty(_txtName.Text))
                return;

            character.Profession = _cbProfession.SelectedItem.ToString();
            character.Race = _cbRace.SelectedItem.ToString();

            //attributes
            character.Strength = DecimalToInt(_nudStrength.Value);
            character.Intelligence = DecimalToInt(_nudIntelligence.Value);
            character.Agility = DecimalToInt(_nudIntelligence.Value);
            character.Constitution = DecimalToInt(_nudConstitution.Value);
            character.Charisma = DecimalToInt(_nudCharisma.Value);

            character.Description = _txtDescription.Text;

            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private int DecimalToInt(decimal value)
        {
            return Convert.ToInt32(value);
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {
            AddClasses();
            AddRaces();

            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _cbProfession.SelectedItem = Character.Profession;
                _cbRace.SelectedItem = Character.Race;
                _nudStrength.Value = Character.Strength;
                _nudIntelligence.Value = Character.Intelligence;
                _nudAgility.Value = Character.Agility;
                _nudConstitution.Value = Character.Constitution;
                _nudCharisma.Value = Character.Charisma;
                _txtDescription.Text = Character.Description;
            };
        }

        private void AddClasses()
        {
            _cbProfession.Items.Add("Fighter");
            _cbProfession.Items.Add("Hunter");
            _cbProfession.Items.Add("Priest");
            _cbProfession.Items.Add("Rouge");
            _cbProfession.Items.Add("Wizard");
            _cbProfession.Items.Add("Paladin");
        }

        private void AddRaces()
        {
            _cbRace.Items.Add("Human");
            _cbRace.Items.Add("Dwarf");
            _cbRace.Items.Add("Gnome");
            _cbRace.Items.Add("Elf");
            _cbRace.Items.Add("Orc");
            _cbRace.Items.Add("Undead");
            _cbRace.Items.Add("Troll");
            _cbRace.Items.Add("Goblin");

        }
    }
}
