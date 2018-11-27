/*
 * ITSE 1430
 * Daniel Clement
 */

namespace ContactManager
{
    public interface IMessage
    {
        /// <summary>
        /// Sends a message
        /// </summary>
        /// <param name="emailAddress">The user's email that is being sent too</param>
        /// <param name="subject">subject of the email</param>
        /// <param name="message">message of the email</param>
        void SendMessage(string emailAddress, string subject, string message);
    }
}