using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    internal class Contact : ICloneable
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
                    if (_fullName.Length >=100)
                    {
                        throw new ArgumentException($"Contact's full name must be less than {_fullName.Length}");
                    }
                    _fullName = value;
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
                    return _phoneNumber;
                }
                set
                {
                    string PhoneNumberValidation = @"^(((\+7|7|8)(\d{3})\)\d{3}-(\d{2}-\d{2}))$)";
                    if(!Regex.IsMatch(_phoneNumber, PhoneNumberValidation))
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
                    if (_dateOfBirth.Year <= 1900 && _dateOfBirth.Year >= 2023)
                    {
                        throw new ArgumentException($"Year must be less than current year" + $"But was {_dateOfBirth.Year}");
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
                    if (_vkId.Length >= 50)
                    {
                        throw new ArgumentException($"Contact's Vk ID must be less than {_vkId.Length}");
                    }
                    _vkId = value;
                }
            }

           ///  <summary>
           /// Создает экземпляр <see cref="Contact">
           /// </summary>
            public Contact(string fullname, string email, string phonenumber, DateTime dateofbirth, string vkid)
            {
                FullName = fullname;
                Email = email;
                PhoneNumber = phonenumber;
                DateOfBirth = dateofbirth;
                VkId = vkid;
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