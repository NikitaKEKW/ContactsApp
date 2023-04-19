using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            public string FullName
            {
                get
                {
                    return _fullName;
                }
                set
                {
                    if (value.Length >=100)
                    {
                        throw new ArgumentException($"Contact's full name must be less than {_fullName.Length}");
                    }
                         TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                        _fullName = ti.ToTitleCase(value).ToString();
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
                    if (value.ToString().Length >= 100)
                    {
                        throw new ArgumentException($"Contact's email must be less than {_email.Length}");
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
                   string PhoneNumberValidation = @"^((\+7|7|8)[\(]?(\d{3})[\)]?\d{3}[-]?(\d{2}[-]?\d{2}))$";
                   if(!Regex.IsMatch(value.ToString(), PhoneNumberValidation))
                   {
                        throw new ArgumentException($"The phone number contains an invalid character.");
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
                    if (_dateOfBirth.Year <= 1900 && _dateOfBirth.Year >= DateTime.Now.Year)
                    {
                        throw new ArgumentException($"Incorrect year" + $"Year was {_dateOfBirth.Year}");
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
                    if (value.ToString().Length >= 50)
                    {
                        throw new ArgumentException($"Contact's Vk ID must be less than {_vkId.Length}");
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

        public Contact()
        {
        }

        ///  <summary>
        /// Клонирует экзмепляр класса
        /// </summary>
        public object Clone()
            {
                return MemberwiseClone();
            }
         }
     }