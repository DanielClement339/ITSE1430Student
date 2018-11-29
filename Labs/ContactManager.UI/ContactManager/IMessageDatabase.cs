/*
 * ITSE 1430
 * Daniel Clement
 */

using System.Collections.Generic;

namespace ContactManager
{
    public interface IMessageDatabase
    {
        void Send(Message message);

        IEnumerable<Message> GetAll();
    }
}