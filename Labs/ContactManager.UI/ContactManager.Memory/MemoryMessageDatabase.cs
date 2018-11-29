/*
 * ITSE 1430
 * Daniel Clement
 */

using System.Collections.Generic;
using System.Linq;

namespace ContactManager.Memory
{
    public class MemoryMessageDatabase : MessageDatabase
    {
        private List<Message> _items = new List<Message>();

        protected override IEnumerable<Message> GetAllCore()
        {
            return from item in _items
                   select new Message()
                   {
                       Name = item.Name,
                       EmailAddress = item.EmailAddress,
                       Subject = item.Subject,
                       ComposeMessage = item.ComposeMessage,
                   };
        }

        protected override void SendCore(Message message)
        {
            _items.Add(message);
        }
    }
}