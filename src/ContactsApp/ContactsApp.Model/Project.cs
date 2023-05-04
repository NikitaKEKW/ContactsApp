using System;
using System.Collections.Generic;
using System.Linq;

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
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        /// <summary>
        /// Возвращает отсортированный список контактов
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public List<Contact> SortContactsByFullName(List<Contact> contact)
        {
            var orderByContact = contact.OrderBy(contacts => contacts.FullName).ToList();
            return orderByContact;
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
        /// Возвращает список контактов найденных по подстроке
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="contactName"></param>
        /// <returns></returns>
        public List<Contact> FindContaсts(List<Contact> contact, string contactName)
        {
            var selectedContact = contact.Where(contacts =>contacts.FullName.Contains(contactName)).ToList();
            return (List<Contact>)selectedContact;
        }
    }
}
