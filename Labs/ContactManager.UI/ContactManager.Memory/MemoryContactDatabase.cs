/*
 * ITSE 1430
 * Daniel Clement
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactManager.Memory
{
    public class MemoryContactDatabase : ContactDatabase
    {
        protected override void AddCore(Contact contact) => _items.Add(contact);

        protected override void EditCore(Contact oldContact, Contact newContact)
        {
            //Find movie by name
            _items.Remove(oldContact);

            //Replace it
            _items.Add(newContact);
        }

        protected override Contact FindByName(string name)
        {
            return (from m in _items
                    where String.Compare(name, m.Name, true) == 0
                    select m).FirstOrDefault();
        }

        protected override void RemoveCore(string name)
        {
            var contact = FindByName(name);
            if (contact != null)
                _items.Remove(contact);
        }

        protected override IEnumerable<Contact> GetAllCore()
        {
            return from item in _items
                       //where
                   select new Contact()
                   {
                       Name = item.Name,
                       EmailAddress = item.EmailAddress,
                   };
        }

        private List<Contact> _items = new List<Contact>();
    }
}