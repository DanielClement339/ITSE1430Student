﻿using System;

namespace CharacterCreator
{
    public class CharacterDatabase
    {
        private Character[] _characters = new Character[100];

        public void Add(Character character)
        {
            var index = FindNextFreeIndex();
            if (index >= 0)
                _characters[index] = character;
        }

        public void Edit(string name, Character character)
        {
            //Find movie by name
            Remove(name);

            //Replace it
            Add(character);
        }

        public Character[] GetAll()
        {
            var count = 0;
            foreach (var character in _characters)
            {
                if (character != null)
                    ++count;
            };

            var temp = new Character[count];
            var index = 0;
            foreach (var character in _characters)
            {
                if (character != null)
                    temp[index++] = character;
            };

            return temp;
        }
        public void Remove(string name)
        {
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (String.Compare(name, _characters[index]?.Name, true) == 0)
                {
                    _characters[index] = null;
                    return;
                }
            }
        }

        private int FindNextFreeIndex()
        {
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index] == null)
                    return index;
            }
            return -1;
        }
    }
}