using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает список контактов
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Возвращает или задает список контактов
        /// </summary>
        public List<Contact> Contacts  = new List<Contact>();

        /// <summary>
        /// Возвращает отсортированный список контактов
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public List<Contact> SortContactsByFullName(List<Contact> contact)
        {
            var selectedContact = from p in contact
            orderby p.FullName
            select p.FullName;
            return (List<Contact>)selectedContact;
        }
        
        /// <summary>
        /// Возвращает список именниников
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public List<Contact> FindBirthdaysToday(List<Contact> contact)
        {
            var selectedContact = from p in contact
            where p.DateOfBirth == DateTime.Now
            select p;
            return (List<Contact>)selectedContact;
        }

        /// <summary>
        /// Возвращает контакты найденные по подстроке
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public List<Contact> FindContants(List<Contact> contact)
        {
            string contactToFind = "Данилик";
            var selectedContact = from p in contact
            where p.FullName == contactToFind
            select p;
            return (List<Contact>)selectedContact;
        }
    }
}
