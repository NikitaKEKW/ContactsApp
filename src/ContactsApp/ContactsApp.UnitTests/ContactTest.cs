using System;
using NUnit.Framework;
using ContactsApp.Model;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ContactTest
    {

        [TestCase("Смирнов", "Геттер FullName возвращает неправильную фамилию",
            TestName = "Позитивный тест геттера FullName")]
        public void FullName_SetCorrectFullName_ReturnsFullName(string fullName, string message)
        {
            //Arrange
            var expected = fullName;
            var contact = new Contact();
            contact.FullName = expected;

            //Act
            var actual = contact.FullName;

            //Assert
            Assert.AreEqual(expected, actual, message);
        }

        [TestCase("asdf@mail.ru", "Геттер Email возвращает неправильную фамилию",
            TestName = "Позитивный тест геттера Email")]
        public void Email_SetCorrectEmail__ReturnsEmail(string email, string message)
        {
            //Arrange
            var expected = email;
            var contact = new Contact();
            contact.Email = expected;

            //Act
            var actual = contact.Email;

            //Assert
            Assert.AreEqual(expected, actual, message);
        }

        [TestCase("+79680695924", "Геттер Phone возвращает неправильный номер телефона",
            TestName = "Позитивный тест геттера Phone")]
        [TestCase("+7(968)0695924", "Геттер Phone возвращает неправильный номер телефона",
            TestName = "Позитивный тест геттера Phone")]
        [TestCase("89680695924", "Геттер Phone возвращает неправильный номер телефона",
            TestName = "Позитивный тест геттера Phone")]
        [TestCase("+7(968)069-59-24", "Геттер Phone возвращает неправильный номер телефона",
            TestName = "Позитивный тест геттера Phone")]
        [TestCase("+7968069-59-24", "Геттер Phone возвращает неправильный номер телефона",
            TestName = "Позитивный тест геттера Phone")]
        public void Phone_SetCorrectPhone_ReturnsPhone(string phone, string message)
        {
            //Arrange
            var expected = phone;
            var contact = new Contact();
            contact.PhoneNumber = expected;

            //Act
            var actual = contact.PhoneNumber;

            //Assert
            Assert.AreEqual(expected, actual, message);
        }

        [TestCase(2000, 10, 10, "Геттер DateOfBirth возвращает неправильную фамилию",
            TestName = "Позитивный тест геттера DateOfBirth")]
        public void DateOfBirth_SetCorrectDateOfBirth_ReturnsDateOfBirth(int year, int month, int day, string message)
        {
            //Arrange
            var expected = new DateTime(year, month, day);
            var contact = new Contact();
            contact.DateOfBirth = expected;

            //Act
            var actual = contact.DateOfBirth;

            //Assert
            Assert.AreEqual(expected, actual, message);
        }

        [TestCase("@superid01", "Геттер IdVk возвращает неправильную фамилию",
            TestName = "Позитивный тест геттера IdVk")]
        public void IdVk_SetCorrectIdVk_ReturnsIdVk(string idVk, string message)
        {
            //Arrange
            var expected = idVk;
            var contact = new Contact();
            contact.VkId = expected;

            //Act
            var actual = contact.VkId;
                
            //Assert
            Assert.AreEqual(expected, actual, message);
        }

        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов" +
            "-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов" +
            "-Смирнов-Смирнов-Смирнов-Смирнов-",
            "Должно возникать исключение, если полное имя длиннее 100 символов",
            TestName = "Присвоение неправильного полного имени больше 100 символов")]
        public void FullName_SetTooLongFullName_ThrowsException(string wrongSurname, string message)
        {
            //Arrange
            var contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    //Act
                    contact.FullName = wrongSurname;
                },
                message);
        }

        [TestCase("testtesttesttesttesttesttesttesttesttesttesttest" +
            "testtesttesttesttesttesttesttesttesttesttesttesttest" +
            "testtesttesttesttesttest@mail.ru",
            "Должно возникать исключение если почта длиннее 100 символов",
            TestName = "Присвоение неправильной почты больше 100 символов")]
        public void Email_SetTooLongEmail_ThrowsException(string wrongEmail, string message)
        {
            //Arrange
            var contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    //Act
                    contact.Email = wrongEmail;
                },
                message);
        }

        [TestCase("", "Должно возникать исключение, если номер телефона пустой",
            TestName = "Присвоение пустой строки в качестве номера телефона")]
        [TestCase("89234427925S!Й", "Должно возникать исключение, если номер телефона содержит символы",
            TestName = "Присвоение чисел с символами в качестве номера телефона")]
        [TestCase("7(8)1-924", "Должно возникать исключение, если номер телефона не полный",
            TestName = "Присвоение не шаблонного номера телефона")]
        [TestCase("7(8123)123-123-5412", "Должно возникать исключение, если номер телефона не полный",
            TestName = "Присвоение не шаблонного номера телефона")]
        [TestCase("7((*8123)123-123-5412", "Должно возникать исключение, если номер телефона содержит" +
            "некорректные символы",
            TestName = "Присвоение не шаблонного номера телефона")]
        [TestCase("7(813)()123--13-12", "Должно возникать исключение, если номер телефона " +
            "содержит лишние символы",
            TestName = "Присвоение не шаблонного номера телефона")]
        public void Phone_SetPhoneInWrongFormat_ThrowsException(string wrongNumber, string message)
        {
            //Arrange
            var contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    //Act
                    contact.PhoneNumber = wrongNumber;
                },
                message);
        }

        [TestCase(2222, 1, 1,
            "Должно возникать исключение, если год рождения больше текущего",
            TestName = "Присвоение года рождения больше текущего")]
        [TestCase(1888, 1, 1,
            "Должно возникать исключение,если год рождения меньше 1900 года",
            TestName = "Присвоение года рождения менее 1900 года")]
        public void DateOfBirth_SetDateOfBirthInWrongFormat_ThrowsException(int year, int month, int day, string message)
        {
            //Arrange
            var wrongDateOfBirth = new DateTime(year, month, day);
            var contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    //Act
                    contact.DateOfBirth = wrongDateOfBirth;
                },
                message);
        }

        [TestCase("@id-id-id-id-id-id-id-id-id-id-id-id-id-id-id-id-id-id-id",
            "Должно возникать исключение если ID длиннее 40 символов",
            TestName = "Присвоение неправильного ID больше 40 символов")]
        public void IdVk_SetTooLongIdVk_ThrowsExceptionn(string wrongIdVk, string message)
        {
            //Arrange
            var contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    //Act
                    contact.VkId = wrongIdVk;
                },
                message);
        }
    }
}
