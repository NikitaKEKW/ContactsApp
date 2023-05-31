using System;
using System.Collections.Generic;
using NUnit.Framework;
using ContactsApp.Model;

namespace ContactsApp.UnitTests
{
   
    [TestFixture]
    public class ProjectTest
    {
        [TestCase("Метод сортировки контактов вернул неверные значения списка контактов",
            TestName = "Тестирование сортировки списка контактов")]
        public void Contacts_SortContactsByFullName_ReturnsValue(string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "C",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"),
                new Contact(
                    "B",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2010, 12, 12),
                    "@test"),
                new Contact(
                    "A",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2001, 12, 12),
                    "@test")
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "A",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2001, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2010, 12, 12),
                    "@test"),
                new Contact(
                    "C",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test")
            };

            //Act
            var actual = new Project();
            actual.Contacts = project.SortContactsByFullName(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts[0].FullName,actual.Contacts[0].FullName, message);
        }

        [TestCase("Метод сортировки контактов вернул неверные значения списка контактов",
            TestName = "Тестирование сортировки пустого списка контактов")]
        public void Contacts_SortContactsWithoutValues_ReturnsValue(string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>();

            var expected = new Project();
            expected.Contacts = new List<Contact>();

            //Act
            var actual = new Project();
            actual.Contacts = project.SortContactsByFullName(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts,actual.Contacts, message);
        }

        [TestCase("Метод сортировки контактов вернул неверные значения списка контактов",
            TestName = "Тестирование уже отсортированного списка контактов")]
        public void Contacts_SortContactsByFullNameWithSortedListContacts_ReturnsValue(
            string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "A",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "A",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"),
                new Contact(
                    "C",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test")
            };

            //Act
            var actual = new Project();
            actual.Contacts = project.SortContactsByFullName(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts[0].FullName,
                actual.Contacts[0].FullName, message);
        }

        [TestCase("Метод поиска именинников вернул неверное значения списка контактов",
            TestName = "Тестирование поиска именинников")]
        public void Contacts_FindBirthdayContacts_ReturnsValue(string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "A",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "asdf@mail.ru",
                    "+79680695924",
                    DateTime.Today,
                    "@test"
                    )
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "C",
                    "asdf@mail.ru",
                    "+79680695924",
                    DateTime.Today,
                    "@test"
                    ),
            };

            //Act
            var actual = new Project();
            actual.Contacts = project.FindBirthdayContacts(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts[0].FullName,actual.Contacts[0].FullName, message);
        }

        [TestCase("Метод поиска именинников вернул неверное значения списка контактов",
            TestName = "Тестирование поиска именинников если сегодня их нет")]
        public void Contacts_FindBirthdayContactsWithoutBirthdayContacts_ReturnsValue(string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "A",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>();

            //Act
            var actual = new Project();
            actual.Contacts = project.FindBirthdayContacts(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts,actual.Contacts, message);
        }

        [TestCase("Метод поиска именинников вернул неверное значения списка контактов",
            TestName = "Тестирование поиска именинников если список контактов пустой")]
        public void Contacts_FindBirthdayContactsWithEmptyListContacts_ReturnsValue(string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>();

            var expected = new Project();
            expected.Contacts = new List<Contact>();

            //Act
            var actual = new Project();
            actual.Contacts = project.FindBirthdayContacts(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts,actual.Contacts, message);
        }

        [TestCase("Смирнов", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Тестирование поиска контактов")]
        public void Contacts_FindContacts_ReturnsValue(string contactName, string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            //Act
            var actual = new Project();
            actual.Contacts = project.FindContaсts(project.Contacts, contactName);

            //Assert
            Assert.AreEqual(expected.Contacts[0].FullName,actual.Contacts[0].FullName, message);
        }

        [TestCase("Смирнов", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Тестирование поиска контактов в пустом списке контактов")]
        public void Contacts_FindContactsWithEmptyListContacts_ReturnsValue(string contactName, string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>();

            var expected = new Project();
            expected.Contacts = new List<Contact>();

            //Act
            var actual = new Project();
            actual.Contacts = project.FindContaсts(project.Contacts, contactName);

            //Assert
            Assert.AreEqual(expected.Contacts,actual.Contacts, message);
        }

        [TestCase("", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Тестирование поиска контактов с пустым искомым контактом")]
        public void Contacts_FindContactsWithEmptySubstring_ReturnsValue(string contactName, string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "asdf@mail.ru",
                    "+79680695924",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            //Act
            var actual = new Project();
            actual.Contacts = project.FindContaсts(project.Contacts, contactName);

            //Assert
            Assert.AreEqual(expected.Contacts[0].FullName, actual.Contacts[0].FullName, message);
        }

        [TestCase("", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Тестирование поиска контактов в пустом списке контактов" +
            "с пустым искомым контактом")]
        public void Contacts_FindContactsWithEmptyListContactsWithoutSubstring_ReturnsValue(string contactName, string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>();

            var expected = new Project();
            expected.Contacts = new List<Contact>();

            //Act
            var actual = new Project();
            actual.Contacts = project.FindContaсts(project.Contacts, contactName);

            //Assert
            Assert.AreEqual(expected.Contacts,actual.Contacts, message);
        }
    }
}