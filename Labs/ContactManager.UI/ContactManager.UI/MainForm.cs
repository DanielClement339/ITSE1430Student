/*
 * ITSE 1430
 * Daniel Clement
 */

using ContactManager.Memory;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class MainForm : Form
    {
        private IContactDatabase _contactDatabase = new MemoryContactDatabase();

        private IMessageDatabase _messageDatabase = new MemoryMessageDatabase();

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _listContacts.DisplayMember = "Name";
            _listMessages.DisplayMember = "Name";
            RefreshContacts();
            RefreshMessages();
        }

        private Contact GetSelectedContact()
        {
            return _listContacts.SelectedItem as Contact;
        }

        private Message GetSelectedMessage()
        {
            return _listMessages.SelectedItem as Message;
        }

        private void OnAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Daniel Clement\nITSE 1430\nCharacter Creator", "About");
        }

        private void OnContactAdd(object sender, EventArgs e)
        {
            var form = new ContactForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            try
            {
                _contactDatabase.Add(form.Contact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshContacts();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                        "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }
        private void OnSend(object sender, EventArgs e)
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new EmailForm
            {
                Contact = item
            };
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            try
            {
                _messageDatabase.Send(form.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshMessages();
        }

        private void RefreshContacts()
        {
            //OrderBy
            //var movies = _database.GetAll();
            var contacts = from m in _contactDatabase.GetAll()
                         orderby m.Name
                         select m;

            _listContacts.Items.Clear();

            //Use ToArray extension method from LINQ
            _listContacts.Items.AddRange(contacts.ToArray());
        }

        private void RefreshMessages()
        {
            var messages = from m in _messageDatabase.GetAll()
                           select m;

            _listMessages.Items.Clear();

            //Use ToArray extension method from LINQ
            _listMessages.Items.AddRange(messages.ToArray());
        }

        private void OnDelete(object sender, EventArgs e)
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            if (MessageBox.Show("Are you sure you want to delete " + item.Name + " ?",
                     "Delete Contact", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _contactDatabase.Remove(item.Name);
            RefreshContacts();
        }

        private void OnEdit(object sender, EventArgs e)
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new ContactForm
            {
                Text = "Edit Contact",
                Contact = item
            };
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _contactDatabase.Edit(item.Name, form.Contact);
            RefreshContacts();
        }
    }
}