using System;
using System.Collections.Generic;
using NUnit.Framework;
using ContactsApp.Model;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        private Project _project;

        private Project _expected;

        private Project _actual;

        [SetUp]
        public void InitProject()
        {
            _project = new Project();
            _expected = new Project();
            _actual = new Project();
        }

        [TestCase("Метод сортировки контактов вернул неверные значения списка контактов",
            TestName = "Тестирование сортировки списка контактов")]
        public void Contacts_SortContactsByFullName_ReturnsValue(string message)
        {
            //Arrange
            _project.Contacts = new List<Contact>()
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

            _expected.Contacts = new List<Contact>()
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
            _actual.Contacts = _project.SortContactsByFullName(_project.Contacts);

            //Assert
            Assert.AreEqual(_expected.Contacts[0].FullName,_actual.Contacts[0].FullName, message);
        }

        [TestCase("Метод сортировки контактов вернул неверные значения списка контактов",
            TestName = "Тестирование сортировки пустого списка контактов")]
        public void Contacts_SortContactsWithoutValues_ReturnsValue(string message)
        {
            //Arrange
            _project.Contacts = new List<Contact>();

            _expected.Contacts = new List<Contact>();

            //Act
            _actual.Contacts = _project.SortContactsByFullName(_project.Contacts);

            //Assert
            Assert.AreEqual(_expected.Contacts,_actual.Contacts, message);
        }

        [TestCase("Метод сортировки контактов вернул неверные значения списка контактов",
            TestName = "Тестирование уже отсортированного списка контактов")]
        public void Contacts_SortContactsByFullNameWithSortedListContacts_ReturnsValue(
            string message)
        {
            //Arrange
            _project.Contacts = new List<Contact>()
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

            _expected.Contacts = new List<Contact>()
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
            _actual.Contacts = _project.SortContactsByFullName(_project.Contacts);

            //Assert
            Assert.AreEqual(_expected.Contacts[0].FullName,
                _actual.Contacts[0].FullName, message);
        }

        [TestCase("Метод поиска именинников вернул неверное значения списка контактов",
            TestName = "Тестирование поиска именинников")]
        public void Contacts_FindBirthdayContacts_ReturnsValue(string message)
        {
            //Arrange
            _project.Contacts = new List<Contact>()
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

            _expected.Contacts = new List<Contact>()
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
            _actual.Contacts = _project.FindBirthdayContacts(_project.Contacts);

            //Assert
            Assert.AreEqual(_expected.Contacts[0].FullName,_actual.Contacts[0].FullName, message);
        }

        [TestCase("Метод поиска именинников вернул неверное значения списка контактов",
            TestName = "Тестирование поиска именинников если сегодня их нет")]
        public void Contacts_FindBirthdayContactsWithoutBirthdayContacts_ReturnsValue(string message)
        {
            //Arrange
            _project.Contacts = new List<Contact>()
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

            _expected.Contacts = new List<Contact>();

            //Act
            _actual.Contacts = _project.FindBirthdayContacts(_project.Contacts);

            //Assert
            Assert.AreEqual(_expected.Contacts,_actual.Contacts, message);
        }

        [TestCase("Метод поиска именинников вернул неверное значения списка контактов",
            TestName = "Тестирование поиска именинников если список контактов пустой")]
        public void Contacts_FindBirthdayContactsWithEmptyListContacts_ReturnsValue(string message)
        {
            //Arrange
            _project.Contacts = new List<Contact>();

            _expected.Contacts = new List<Contact>();

            //Act
            _actual.Contacts = _project.FindBirthdayContacts(_project.Contacts);

            //Assert
            Assert.AreEqual(_expected.Contacts,_actual.Contacts, message);
        }

        [TestCase("Смирнов", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Тестирование поиска контактов")]
        public void Contacts_FindContacts_ReturnsValue(string contactName, string message)
        {
            //Arrange
            _project.Contacts = new List<Contact>()
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

            _expected.Contacts = new List<Contact>()
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
            _actual.Contacts = _project.FindContaсts(_project.Contacts, contactName);

            //Assert
            Assert.AreEqual(_expected.Contacts[0].FullName,_actual.Contacts[0].FullName, message);
        }

        [TestCase("Смирнов", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Тестирование поиска контактов в пустом списке контактов")]
        public void Contacts_FindContactsWithEmptyListContacts_ReturnsValue(string contactName, string message)
        {
            //Arrange
            _project.Contacts = new List<Contact>();

            _expected.Contacts = new List<Contact>();

            //Act
            _actual.Contacts = _project.FindContaсts(_project.Contacts, contactName);

            //Assert
            Assert.AreEqual(_expected.Contacts,_actual.Contacts, message);
        }

        [TestCase("", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Тестирование поиска контактов с пустым искомым контактом")]
        public void Contacts_FindContactsWithEmptySubstring_ReturnsValue(string contactName, string message)
        {
            //Arrange
            _project.Contacts = new List<Contact>()
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

            _expected.Contacts = new List<Contact>()
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
            _actual.Contacts = _project.FindContaсts(_project.Contacts, contactName);

            //Assert
            Assert.AreEqual(_expected.Contacts[0].FullName, _actual.Contacts[0].FullName, message);
        }

        [TestCase("", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Тестирование поиска контактов в пустом списке контактов" +
            "с пустым искомым контактом")]
        public void Contacts_FindContactsWithEmptyListContactsWithoutSubstring_ReturnsValue(string contactName, string message)
        {
            //Arrange
            _project.Contacts = new List<Contact>();

            _expected.Contacts = new List<Contact>();

            //Act
            _actual.Contacts = _project.FindContaсts(_project.Contacts, contactName);

            //Assert
            Assert.AreEqual(_expected.Contacts,_actual.Contacts, message);
        }
    }
}