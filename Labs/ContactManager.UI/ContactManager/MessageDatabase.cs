/*
 * ITSE 1430
 * Daniel Clement
 */

using System.Collections.Generic;

namespace ContactManager
{
    public abstract class MessageDatabase : IMessageDatabase
    {
        public void Send(Message message)
        {
            if (message == null)
                return;

            SendCore(message);
        }

        public IEnumerable<Message> GetAll()
        {
            return GetAllCore();
        }

        protected abstract void SendCore(Message message);

        protected abstract IEnumerable<Message> GetAllCore();
    }
}