using System;
using System.Collections.Generic;
using NUnit.Framework;
using ContactsApp.Model;


namespace ContactApp.UnitTests
{
    [TestFixture]
    class ProjectTest
    {
        [TestCase("Список контактов не отсортирован, так как список пустой",
            TestName = "Тест сортировки списка контактов без значений")]
        public void Project_SortContactsListWithoutContacts_ReturnsValue(string message)
        {
            // Arrange
            var expected = new Project();
            expected.Contacts = new List<Contact>();
            var project = new Project();
            project.Contacts = new List<Contact>();

            // Act
            var actual = new Project();
            project.SortContactsByFullName();
            actual = project;

            // Assert
            Assert.That(actual.Contacts, Is.EqualTo(expected.Contacts), message);
        }

        [TestCase("Список контактов не отсортирован",
            TestName = "Тест сортировки списка имеющего контакты")]
        public void Project_SortContactsList_ReturnsValue(string message)
        {
            // Arrange  
            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов Андрей","Smirno@mail.ru","+7(978)0695925",DateTime.Today,"@id123"),
                new Contact(
                    "Котчетов Иван","kochid@mail.ru","+7(978)0695927",DateTime.Today,"@id456"),
                new Contact(
                    "Гавриленко Михаил","mixa@mail.ru","+7(978)0695928",DateTime.Today,"@id789")

            };
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов Андрей","Smirno@mail.ru","+7(978)0695925",DateTime.Today,"@id123"),
                new Contact(
                    "Котчетов Иван","kochid@mail.ru","+7(978)0695927",DateTime.Today,"@id456"),
                new Contact(
                    "Гавриленко Михаил","mixa@mail.ru","+7(978)0695928",DateTime.Today,"@id789")
            };

            // Act
            var actual = new Project();
            project.SortContactsByFullName();
            actual = project;

            // Assert
            Assert.That(actual.Contacts[1].FullName, Is.EqualTo(expected.Contacts[1].FullName), message);
        }

        [TestCase("Отсортированный список контактов не отсортирован",
            TestName = "Тест сортировки отсортированного списка контактов")]
        public void Project_SortSortedContactsList_ReturnsValue(string message)
        {
            // Arrange
            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов Андрей","Smirno@mail.ru","+7(978)0695925",DateTime.Today,"@id123"),
                new Contact(
                    "Котчетов Иван","kochid@mail.ru","+7(978)0695927",DateTime.Today,"@id456"),
                new Contact(
                    "Гавриленко Михаил","mixa@mail.ru","+7(978)0695928",DateTime.Today,"@id789")
            };
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "Гавриленко Михаил","mixa@mail.ru","+7(978)0695928",DateTime.Today,"@id789"),
                new Contact(
                    "Котчетов Иван","kochid@mail.ru","+7(978)0695927",DateTime.Today,"@id456"),
                new Contact(
                    "Смирнов Андрей","Smirno@mail.ru","+7(978)0695925",DateTime.Today,"@id123"),
            };

            // Act
            var actual = new Project();
            project.SortContactsByFullName();
            actual = project;

            // Assert
            Assert.That(actual.Contacts[1].FullName, Is.EqualTo(expected.Contacts[1].FullName), message);
        }

        [TestCase("", "Контакты не найдены",
           TestName = "Тест поиска контактов в пустом списке с пустым искомым контактом")]
        public void Project_SearchContactsInEmptyListWithoutSubstringValue_ReturnsValue
           (string searchedValue, string message)
        {
            // Arrange
            var expected = new Project();
            expected.Contacts = new List<Contact>();
            var project = new Project();
            project.Contacts = new List<Contact>();

            // Act
            var actual = new Project();
            actual.Contacts = project.FindContaсts(project.Contacts, searchedValue);

            // Assert
            Assert.That(actual.Contacts, Is.EqualTo(expected.Contacts), message);
        }

        [TestCase("Данил", "Контакты не найдены",
           TestName = "Тест поиска контактов в пустом списке с искомым значением")]
        public void Project_SearchContactsInEmptyListWithSubstingValue_ReturnsValue
           (string searchedValue, string message)
        {
            // Arrange
            var expected = new Project();
            expected.Contacts = new List<Contact>();
            var project = new Project();
            project.Contacts = new List<Contact>();

            // Act
            var actual = new Project();
            actual.Contacts = project.FindContaсts(project.Contacts, searchedValue);

            // Assert
            Assert.That(actual.Contacts, Is.EqualTo(expected.Contacts), message);
        }

        [TestCase("", "Контакты не найдены",
        TestName = "Тест поиска контактов в полном списке с пустым искомым значением")]
        public void Project_SearchContactsWithoutSubstringValue_ReturnsValue
            (string searchedValue, string message)
        {
            // Arrange
            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов Андрей","Smirno@mail.ru","+7(978)0695925",DateTime.Today,"@id123"),
                new Contact(
                    "Котчетов Иван","kochid@mail.ru","+7(978)0695927",DateTime.Today,"@id456"),
                new Contact(
                    "Гавриленко Михаил","mixa@mail.ru","+7(978)0695928",DateTime.Today,"@id789")
            };
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов Андрей","Smirno@mail.ru","+7(978)0695925",DateTime.Today,"@id123"),
                new Contact(
                    "Котчетов Иван","kochid@mail.ru","+7(978)0695927",DateTime.Today,"@id456"),
                new Contact(
                    "Гавриленко Михаил","mixa@mail.ru","+7(978)0695928",DateTime.Today,"@id789")
            };

            // Act
            var actual = new Project();
            actual.Contacts = project.FindContaсts(project.Contacts, searchedValue);

            // Assert
            Assert.That(actual.Contacts[0].FullName, Is.EqualTo(expected.Contacts[0].FullName), message);
        }

        [TestCase("Кто-то", "Контакты не найдены",
           TestName = "Тест поиска контактов на отсутсвие контакта в полном списке")]
        public void Project_SearchContactsWithoutNeededContact_ReturnsValue
           (string searchedValue, string message)
        {
            // Arrange
            var expected = new Project();
            expected.Contacts = new List<Contact>();
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов Андрей","Smirno@mail.ru","+7(978)0695925",DateTime.Today,"@id123"),
                new Contact(
                    "Котчетов Иван", "kochid@mail.ru", "+7(978)0695927", DateTime.Today, "@id456"),
                new Contact(
                    "Гавриленко Михаил","mixa@mail.ru","+7(978)0695928",DateTime.Today,"@id789")
            };

            // Act
            var actual = new Project();
            actual.Contacts = project.FindContaсts(project.Contacts, searchedValue);

            // Assert
            Assert.That(actual.Contacts, Is.EqualTo(expected.Contacts), message);
        }
    }
}