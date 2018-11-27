using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //TODO: Validate
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
