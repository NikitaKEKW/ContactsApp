using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        /// <summary>
        /// поле класса Contact
        /// </summary>
        private Contact _contact = new Contact("", "", "89680695926", new DateTime(2000, 3, 6), "");

        /// <summary>
        /// Установка и получение экземпляра
        /// </summary>
        public Contact Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                UpdateForm();
            }
        }

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

        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }

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
            string _validationError = null;
            _validationError += _fullNameError;
            _validationError += _emailError;
            _validationError += _phoneNumberError;
            _validationError += _dateOfBirthError;
            _validationError += _vkIdError;
            if (_validationError != null && _validationError != "")
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
            _contact.DateOfBirth = DateOfBirthTimePicker.Value;
            _contact.VkId = VKTextBox.Text;
        }

        /// <summary>
        /// Валидация данных FullName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = FullNameTextBox.Text;
                _fullNameError = null;
                FullNameTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                _fullNameError = ex.Message;
                FullNameTextBox.BackColor = Color.LightPink;
                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// Валидация данных email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                _emailError = null;
                EmailTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                _emailError = ex.Message;
                EmailTextBox.BackColor = Color.LightPink;
                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// Валидация данных PhoneNumber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
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
                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// Валидация данных DateOfBirth
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void DateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = DateOfBirthTimePicker.Value;
                _dateOfBirthError = null;
            }
            catch (Exception ex)
            {
                _dateOfBirthError = ex.Message;
                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// Валидация данных VkID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VkId = VKTextBox.Text;
                _vkIdError = null;
                VKTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                _vkIdError = ex.Message;
                VKTextBox.BackColor = Color.LightPink;
                throw new ArgumentException(ex.Message);
            }
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
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            bool CheckError = CheckFormOnErrors();
            if (CheckError)
            {
                UpdateContact();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}