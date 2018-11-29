/*
 * ITSE 1430
 * Daniel Clement
 */

using System.Collections.Generic;

namespace ContactManager
{
    public interface IContactDatabase
    {
        /// <summary>Adds a contact to the database.</summary>
        /// <param name="contact">The contact to add.</param>
        void Add(Contact contact);

        /// <summary>Edits an existing contact.</summary>
        /// <param name="name">The contact to edit.</param>
        /// <param name="contact">The new contact.</param>
        void Edit(string name, Contact contact);

        /// <summary>Gets all the contact.</summary>
        /// <returns>The list of contact.</returns>
        IEnumerable<Contact> GetAll();

        /// <summary>Removes a contact.</summary>
        /// <param name="name">The contact to remove.</param>
        void Remove(string name);
    }
}