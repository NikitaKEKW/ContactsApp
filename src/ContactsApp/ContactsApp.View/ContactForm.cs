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

        private Contact _contact = new Contact();

        private string _fullNameError;

        private string _emailError;

        private string _phoneNumberError;

        private string _dateOfBirthError;

        private string _vkIdError;

        private void UpdateForm()
        {
            _contact.DateOfBirth = new DateTime(2002, 3, 6);
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            DateOfBirthTimePicker.Value = _contact.DateOfBirth;
            VKTextBox.Text = _contact.VkId;
        }
        public ContactForm()
        {
            InitializeComponent();
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
            this.Close();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
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
         //   try
          //  {
         //       _contact.PhoneNumber = PhoneNumberTextBox.Text;
           //     PhoneNumberTextBox.BackColor = Color.White;

          //  }
         //   catch (Exception ex)
           // {
           //     _phoneNumberError = ex.Message;
            //    PhoneNumberTextBox.BackColor = Color.LightPink;
             //   throw new ArgumentException(_phoneNumberError);
         //   }

        }

        private void DateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
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
