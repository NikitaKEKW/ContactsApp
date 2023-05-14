using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using ContactsApp.Model;
using static System.ActivationContext;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле класса  <see cref="Project"> 
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Список класса <see cref="Contact"> 
        /// Хранит данные контактов
        /// используется для сортировки и поиска контактов
        /// </summary>
        private List<Contact> _currentContacts = new List<Contact>();

        /// <summary>
        /// Список класса <see cref="Contact">
        /// Хранит контакты у которых сегодня день рождения
        /// </summary>
        private List<Contact> _birthdayContacts = new List<Contact>();

        /// <summary>
        /// Метод по обновлению списка контактов
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            _project.Contacts = _project.SortContactsByFullName(_project.Contacts);
            _currentContacts = _project.FindContaсts(_project.Contacts, FindTextBox.Text);

            foreach (Contact contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
            ShowBirthdayContacts();
        }

        /// <summary>
        /// Метод добавления контакта в список
        /// </summary>
        private void AddContact()
        {
            Contact contact = new Contact("", "", "8(913)999-99-99", DateTime.Now, "");
            var addForm = new ContactForm();
            addForm.Contact = contact;
            addForm.ShowDialog();
            var updatedContact = addForm.Contact;
            if (addForm.DialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(updatedContact);
            }
        }

        /// <summary>
        /// Добавление рандомных данных в список
        /// </summary>
        private void AddRandomContacts()
        {
            _project = RandomData.CreateRandomContactsData();
        }

        private void EditContact(int index)
        {
            var cloneContact = (Contact)_project.Contacts[index].Clone();
            var editForm = new ContactForm();
            editForm.Contact = cloneContact;
            editForm.ShowDialog();
            var updatedContact = editForm.Contact;
            int someValue = _project.Contacts.IndexOf(_currentContacts[index]);
            if (editForm.DialogResult == DialogResult.OK)
            {
                var updatedData = editForm.Contact;
                ContactsListBox.Items.RemoveAt(index);
                _project.Contacts.RemoveAt(index);
                _project.Contacts.Insert(index, updatedData);
            }
        }

        /// <summary>
        /// Метод удаления контакта из списка
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            if (index == -1)
            {
                return;
            }
            DialogResult result = MessageBox.Show(
                $"Do you really want to remove {_project.Contacts[index].FullName}?",
                "Delete contact",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                _project.Contacts.RemoveAt(index);
            }
        }

        /// <summary>
        /// Метод обновления данных о контакте в правой панели главного окна
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            Contact contactValue = _project.Contacts[index];
            FullNameTextBox.Text = contactValue.FullName;
            EmailTextBox.Text = contactValue.Email;
            PhoneNumberTextBox.Text = contactValue.PhoneNumber;
            DateOfBirthTextBox.Text = contactValue.DateOfBirth.ToString();
            VKTextBox.Text = contactValue.VkId;
        }

        /// <summary>
        /// Вывод контактов у которых день рождения
        /// </summary>
        private void ShowBirthdayContacts()
        {
            _birthdayContacts = _project.FindBirthdayContacts(_project.Contacts);
            BirthdaySurnameLabel.Text = "";
            for (int i = 0; i < 1; i++)
            {
                BirthdaySurnameLabel.Text += $"{_birthdayContacts[i].FullName} ";
            }
            BirthdaySurnameLabel.Text += "и др.";
        }

        /// <summary>
        /// Метод очистки данных о контакте в правой панели главного окна
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            DateOfBirthTextBox.Text = "";
            VKTextBox.Text = "";
        }

        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            ClearSelectedContact();
            UpdateListBox();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                ClearSelectedContact();
            }
            else UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you really want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        private void DeleteContactButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteContactButton.Image = Properties.Resources.remove_contact_32x32;
            DeleteContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }

        private void DeleteContactButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            DeleteContactButton.BackColor = Color.White;
        }

        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }

        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var FormAbout = new AboutForm();
                FormAbout.ShowDialog();
            }
        }
    }
}
