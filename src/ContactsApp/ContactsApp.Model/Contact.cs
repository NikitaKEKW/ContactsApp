using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает контакт
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Полное имя контакта
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Электронная почта контакта
        /// </summary>
        private string _email;

        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Дата рождения контакта
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// ID Вконтакте контакта
        /// </summary>
        private string _vkId;

        /// <summary>
        /// Возвращает или задает полное имя контакта
        /// </summary>

        /// <summary>
        /// Поле проверки номера телефона
        /// </summary>
        private const string PhoneNumberValidation =
                    @"^((\+7|8)[\(]?(\d{3})[\)]?\d{3}[-]?(\d{2}[-]?\d{2}))$";

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (value.Length >= 100)
                {
                    throw new ArgumentException(
                        $"Contact's full name must be less than {value.Length}");
                }
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                _fullName = textInfo.ToTitleCase(value).ToString();
            }
        }

        /// <summary>
        /// Возвращает или задает электронную почту контакта
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length >= 100)
                {
                    throw new ArgumentException(
                        $"Contact's email must be less than {value.Length}");
                }
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает или задает номер телефона контакта
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (!Regex.IsMatch(value, PhoneNumberValidation))
                {
                    throw new ArgumentException(
                        $"The phone number entered incorrectly.\nFor example you need to enter:\n"
                        + $"8(968)069-59-26\n" + $"89680695926\n" + $"+79680695926" );
                }
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает или задает дату рождения контакта
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value.Year <= 1900 || value > DateTime.Now)
                {
                    throw new ArgumentException(
                        $"Incorrect year. " + $"Year must be less or more than ${value}");
                }
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает ID Вконтакте контакта
        /// </summary>
        public string VkId
        {
            get
            {
                return _vkId;
            }
            set
            {
                if (value.Length >= 50)
                {
                    throw new ArgumentException(
                        $"Contact's Vk ID must be less than {value.Length}");
                }
                _vkId = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Contact">
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="vkId"></param>
        public Contact(string fullName, string email, string phoneNumber, DateTime dateOfBirth, string vkId)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            VkId = vkId;
        }

        /// <summary>
        ///  Создает пустой экземпляр <see cref="Contact">
        /// </summary>
        public Contact() { }

        ///  <summary>
        /// Клонирует экзмепляр класса
        /// </summary>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}