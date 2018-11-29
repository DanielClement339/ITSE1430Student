/*
 * ITSE 1430
 * Daniel Clement
 */

using System;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        public Contact Contact { get; set; }
        public Message Message { get; set; }

        private void OnLoad(object sender, EventArgs e)
        {
            if (Contact != null)
            {
                _txtName.Text = Contact.Name;
                _txtEmail.Text = Contact.EmailAddress;
            }

            if(Message != null)
            {
                _txtSubject.Text = Message.Subject;
                _txtMessage.Text = Message.ComposeMessage;
            }

            ValidateChildren();
        }

        private void OnSend(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var message = new Message
            {
                Name = _txtName.Text,
                EmailAddress = _txtEmail.Text,
                Subject = _txtSubject.Text,
                ComposeMessage = _txtMessage.Text,
            };

            Message = message;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}