/*
 * ITSE 1430
 * Daniel Clement
 */

using System;
using System.Collections.Generic;

namespace ContactManager
{
    public abstract class ContactDatabase : IContactDatabase
    {
        public void Add(Contact contact)
        {
            if (contact == null)
                return;

            AddCore(contact);
        }

        public void Edit(string name, Contact contact)
        {
            if (String.IsNullOrEmpty(name))
                return;
            if (contact == null)
                return;

            //Find movie by name
            var existing = FindByName(name);
            if (existing == null)
                return;

            EditCore(existing, contact);
        }

        public IEnumerable<Contact> GetAll()
        {
            return GetAllCore();
        }

        public void Remove(string name)
        {
            if (String.IsNullOrEmpty(name))
                return;

            RemoveCore(name);
        }

        protected abstract void AddCore(Contact contact);

        protected abstract void EditCore(Contact oldContact, Contact newContact);

        protected abstract Contact FindByName(string name);

        protected abstract void RemoveCore(string name);

        protected abstract IEnumerable<Contact> GetAllCore();
    }
}