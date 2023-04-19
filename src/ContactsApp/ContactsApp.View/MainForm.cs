using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле класса Prohect
        /// </summary>
        private Project _project;

        /// <summary>
        /// Создание объекта для генерации чисел 
        /// </summary>
        Random rnd = new Random();

        /// <summary>
        /// Метод по обновлению списка контактов
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            foreach (Contact contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }

        /// <summary>
        /// Метод добавления контакта в список
        /// </summary>
        private void AddContact()
        {
            _project = new Project();
            string[] arrFullName = { "Данилик", "Зорин", "ПетруШкин", "Кочетов", "Гаврилов" };
            string[] arrEmail = { "dannl@no.mail", "zordl@no.mail", "petsp@no.mail", "kochid@no.mail", "gavdv@no.mail" };
            string[] arrPhoneNumber = { "89684566545", "896321459656", "89874562541", "89521234567", "89329516784" };
            string[] arrVkId = { "@id123654", "@myid", "@id123089", "@id1337228", "@qwerty" };

            var listContact = new List<Contact>();
            int randomContact;

            for (int i = 0; i < 5; i++)
            {
                randomContact = GetRandom(rnd);
                Contact contact = new Contact(arrFullName[randomContact], arrEmail[randomContact],
                    arrPhoneNumber[randomContact], DateTime.Now, arrVkId[randomContact]);
                listContact.Add(contact);
                _project.Contacts.Add(contact);
            }
        }

        /// <summary>
        /// Метод генерации рандомного числа
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns></returns>
        static int GetRandom(Random rnd)
        {
            return rnd.Next(5);
        }

        /// <summary>
        /// Метод удаления контакта из списка
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            if (index == -1) return;
            
            DialogResult result = MessageBox.Show(
                $"Do you really want to remove {_project.Contacts[index].FullName}?",
                "Delete contact",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.OK)

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
            FullNameTextBox.Text = _project.Contacts[index].FullName;
            EmailTextBox.Text = _project.Contacts[index].Email;
            PhoneNumberTextBox.Text = _project.Contacts[index].PhoneNumber;
            DateOfBirthTextBox.Text = _project.Contacts[index].DateOfBirth.ToString();
            VKTextBox.Text = _project.Contacts[index].VkId;
        }

        /// <summary>
        /// Метод очистки данных о контакте в правой панели главного окна
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox = null;
            EmailTextBox = null;    
            PhoneNumberTextBox = null;
            DateOfBirthTextBox = null;
            VKTextBox = null;
        }

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
            var form = new ContactForm();
            form.ShowDialog();
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

        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
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
    }
}
