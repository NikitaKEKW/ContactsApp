using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает контакт
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Полное имя контакта
        /// </summary>
        private string _FullName;

        /// <summary>
        /// Электронная почта контакта
        /// </summary>
        private string _Email;

        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        private string _PhoneNumber;

        /// <summary>
        /// Дата рождения контакта
        /// </summary>
        private int _DateOfBirth;

        /// <summary>
        /// ID Вконтакте контакта
        /// </summary>
        private string _VkId;

        /// <summary>
        /// Возвращает или задает полное имя контакта
        /// </summary>
        public string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                _FullName = value;
            }
        }

        /// <summary>
        /// Возвращает или задает электронную почту контакта
        /// </summary>
        public string Email 
            {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        /// <summary>
        /// Возвращает или задает номер телефона контакта
        /// </summary>
        public string PhoneNumber 
            {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                value =
                _PhoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает или задает дату рождения контакта
        /// </summary>
        public int DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                if (value < 1900 && value > 2023)
                {
                    throw new ArgumentException($"Incorrect Year.");
                }
                _DateOfBirth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает ID Вконтакте контакта
        /// </summary>
        public string VkId
        {
            get
            {
                return _VkId;
            }
            set
            {
                _VkId = value;
            }
        }
    }
}
