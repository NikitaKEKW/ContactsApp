using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    internal class ContactClass
    {
        /// <summary>
        /// Описывает контакт
        /// </summary>
        public class Contact : ICloneable
        {
            /// <summary>
            /// Полное имя контакта
            /// </summary>
            private string _fullname;

            /// <summary>
            /// Электронная почта контакта
            /// </summary>
            private string _email;

            /// <summary>
            /// Номер телефона контакта
            /// </summary>
            private string _phonenumber;

            /// <summary>
            /// Дата рождения контакта
            /// </summary>
            private DateTime _dateofbirth;

            /// <summary>
            /// ID Вконтакте контакта
            /// </summary>
            private string _vkid;

            /// <summary>
            /// Возвращает или задает полное имя контакта
            /// </summary>
            public string FullName
            {
                get
                {
                    return _fullname;
                }
                set
                {
                    if (_fullname.Length >=100)
                    {
                        throw new ArgumentException($"Contact's full name must be less than {_fullname.Length}");
                    }
                    _fullname = value;
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
                    if (_email.Length >= 100)
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
                    return _phonenumber;
                }
                set
                {
                    string PhoneNumberValidation = @"^(((\+7|7|8)(\d{3})\)\d{3}-(\d{2}-\d{2}))$)";
                    if(!Regex.IsMatch(_phonenumber, PhoneNumberValidation))
                    {
                        throw new ArgumentException($"The phone number contains an invalid character.");
                    }
                    _phonenumber = value;
                }
            }

            /// <summary>
            /// Возвращает или задает дату рождения контакта
            /// </summary>
            public DateTime DateOfBirth
            {
                get
                {
                    return _dateofbirth;
                }
                set
                {
                    if (_dateofbirth.Year <= 1900 && _dateofbirth.Year >= 2023)
                    {
                        throw new ArgumentException($"Year must be less than current year" + $"But was {_dateofbirth.Year}");
                    }
                    _dateofbirth = value;
                }
            }

            /// <summary>
            /// Возвращает или задает ID Вконтакте контакта
            /// </summary>
            public string VkId
            {
                get
                {
                    return _vkid;
                }
                set
                {
                    if (_vkid.Length >= 50)
                    {
                        throw new ArgumentException($"Contact's Vk ID must be less than {_vkid.Length}");
                    }
                    _vkid = value;
                }
            }

           ///  <summary>
           /// Создает экземпляр <see cref="Contact">
           /// </summary>
            public Contact(string fullname, string email, string phonenumber, DateTime dateofbirth, string vkid)
            {
                _fullname = fullname;
                _email = email;
                _phonenumber = phonenumber;
                _dateofbirth = dateofbirth;
                _vkid = vkid;
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
 }