using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        /// <summary>
        /// поле класса Contact
        /// </summary>
        private Contact _contact = new Contact();

        /// <summary>
        /// текствое поле ошибки FullName
        /// </summary>
        private string _fullNameError;

        /// <summary>
        /// текствое поле ошибки Email
        /// </summary>
        private string _emailError;

        /// <summary>
        /// текствое поле ошибки PhoneNumber
        /// </summary>
        private string _phoneNumberError;

        /// <summary>
        /// текствое поле ошибки DateOfBirth
        /// </summary>
        private string _dateOfBirthError;

        /// <summary>
        /// текствое поле ошибки VkID
        /// </summary>
        private string _vkIdError;

        /// <summary>
        /// строковое поле с ошибками формы
        /// </summary>
        private string _validationError;

        /// <summary>
        /// Метод по обновлению данных на форме
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            DateOfBirthTimePicker.Value = _contact.DateOfBirth;
            VKTextBox.Text = _contact.VkId;
        }

        /// <summary>
        /// Метод проверки текстовых полей
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            _validationError += _fullNameError;
            _validationError += _emailError;
            _validationError += _phoneNumberError;
            _validationError += _dateOfBirthError;
            _validationError += _vkIdError;

            if (_fullNameError!= null )
            {
                MessageBox.Show($"{_fullNameError}\n{_emailError}\n{_phoneNumberError}\n{_dateOfBirthError}\n{_vkIdError}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        /// <summary>
        /// Метод обновления информации о контакте
        /// </summary>
         private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.PhoneNumber = PhoneNumberTextBox.Text;
            _contact.DateOfBirth= DateOfBirthTimePicker.Value;
            _contact.VkId = VKTextBox.Text;
        }

        public ContactForm()
        {
            InitializeComponent();
            _contact.DateOfBirth = new DateTime(2002, 3, 6);
            _contact.PhoneNumber = "79680695926";
            UpdateForm();
        }

        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }

        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            CheckFormOnErrors();
            UpdateContact();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _fullNameError = null;
                _contact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                _fullNameError = ex.Message;
                FullNameTextBox.BackColor = Color.LightPink;
                throw new ArgumentException(_fullNameError);
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _emailError = null;
                _contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                _emailError = ex.Message;
                EmailTextBox.BackColor = Color.LightPink;
                throw new ArgumentException(_emailError);
            }

        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
               try
               {
                   _phoneNumberError = null;
                   _contact.PhoneNumber = PhoneNumberTextBox.Text;
                   PhoneNumberTextBox.BackColor = Color.White;
                }
               catch (Exception ex)
               {
                   _phoneNumberError = ex.Message;
                   PhoneNumberTextBox.BackColor = Color.LightPink;
                   throw new ArgumentException(_phoneNumberError);
                }

        }

        private void DateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _dateOfBirthError = null;
                _contact.DateOfBirth = DateOfBirthTimePicker.Value;

            }
            catch (Exception ex)
            {
                _dateOfBirthError = ex.Message;
                throw new ArgumentException(_dateOfBirthError);
            }

        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _vkIdError = null;
                _contact.VkId = VKTextBox.Text;
                VKTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                _vkIdError = ex.Message;
                VKTextBox.BackColor = Color.LightPink;
                throw new ArgumentException(_vkIdError);
            }

        }

    }
 }
