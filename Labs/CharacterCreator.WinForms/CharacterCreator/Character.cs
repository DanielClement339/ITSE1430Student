using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        private string _name;
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
        public string Profession { get; set; }
        public string Race { get; set; }
        public string Description { get; set; }

        private decimal _strength;
        public decimal Strength
        {
            get { return _strength; }
            set
            {
                if (value < 0 || value > 100)
                    return;

                _strength = value;
            }
        }

        private int _intelligence;
        public int Intelligence
        {
            get { return _intelligence; }
            set
            {
                if (value < 0 || value > 100)
                    return;

                _intelligence = value;
            }
        }

        private int _agility;
        public int Agility
        {
            get { return _agility; }
            set
            {
                if (value < 0 || value > 100)
                    return;

                _agility = value;
            }
        }

        private int _constitution;
        public int Constitution
        {
            get { return _constitution; }
            set
            {
                if (value < 0 || value > 100)
                    return;
                _constitution = value;
            }
        }

        private int _charisma;
        public int Charisma
        {
            get { return _charisma; }
            set
            {
                if (value < 0 || value > 100)
                    return;

               _charisma = value;
            }
        }
    }
}
