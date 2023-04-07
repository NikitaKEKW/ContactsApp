using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    internal class Project
    {
        /// <summary>
        /// Возвращает или задает контакт
        /// </summary>
        public List<string> Contacts { get; set; } = new List<string>();

        /// <summary>
        /// Метод сортировки контактов по одному имени
        /// </summary>
        public string SortContactsByFullName(Contact contact)
        {
            return contact.FullName;
        }

        /// <summary>
        /// Метод по поиску именников среди контактов
        /// </summary>
        public string FindBirthdaysToday(Contact contact)
        {
            return contact.FullName;
        }

        /// <summary>
        /// Метод по поиску контактов по подстроке
        /// </summary>
        public string FindContants(Contact contact)
        {
            return contact.FullName;
        }
    }
}
