using System;
using System.Collections.Generic;

namespace ContactsApp.Model
{
    public class ContactsInformation
    {

        /// <summary>
        /// Поле класса <see cref="Project">
        /// </summary>
        private static Project _project = new Project();

        /// <summary>
        /// Переменная для генерации случайного числа
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Массив мужских фамилий
        /// </summary>
        private static string[] _arrMaleSurname = { "Попов", "Новиков", "Гончаров", "Левин", "Белов",
            "Михайлов", "Кожевников","Смирнов", "Соколов", "Марков"};

        /// <summary>
        /// Массив женских фамилий
        /// </summary>
        private static string[] _arrFemaleSurname = { "Евдокимова", "Ермолаева", "Рябова", "Морозова",
            "Новикова", "Чернова", "Матвеева", "Степанова", "Дроздова ", "Аникина"};

        /// <summary>
        /// Массив мужский имён
        /// </summary>
        private static string[] _arrMaleName = { "Лев", "Максим", "Александр", "Константин", "Фёдор",
            "Тимур", "Владислав", "Андрей", "Георгий", "Иван"};

        /// <summary>
        /// Массив женских имён
        /// </summary>
        private static string[] _arrFemaleName = { "Ульяна", "Елизавета ", "Дарья ", "Анастасия ", "Софья ",
            "Александра", "Наталья", "Мирослава", "Вероника", "Арина"};

        /// <summary>
        /// Массив мужских отчеств
        /// </summary>
        private static string[] _arrMalePatronymic = { "Николаевич", "Ярославович","Тимурович",
            "Максимович", "Владимирович", "Егорович", "Александрович", "Дамирович",
            "Александрович","Мирославович"};

        /// <summary>
        /// Массив женских отчеств
        /// </summary>
        private static string[] _arrFemalePatronymic = {"Андреевна", "Артуровна", "Фёдоровна", "Степановна",
            "Михайловна", "Ярославовна", "Никитична", "Константиновна", "Марковна", "Ильинична" };

        /// <summary>
        /// Массив электронных почт
        /// </summary>
        private static string[] _arrEmail = { "gjkhp@mail.ru", "wyalkxfde@gmail.com", "f245n@outlook.com",
            "w@outlook.com", "js3kyopz@mail.ru", "o@outlook.com", "uzfd@mail.ru", "g@mail.ru", "dvjf0@gmail.com",
            "d2mc@outlook.com", "06lk@mail.ru", "emhzysf2@yandex.ru", "d1w28lkg@yandex.ru" };

        /// <summary>
        /// Массив мобильных телефонов
        /// </summary>
        private static string[] _arrPhoneNumber = {"+7(968)069-59-58", "+7(968)069-59-57", "+7(968)069-59-56",
        "+7(968)069-59-55","+7(968)069-59-54","+7(968)069-59-53","+7(968)069-59-52","+7(968)069-59-51",
        "+7(968)069-59-50","+7(968)069-59-12","+7(968)069-59-13"};

        /// <summary>
        /// Массив ID Вконтакте
        /// </summary>
        private static string[] _arrIDVk = {"@id1234543", "@idsuper", "@id1234765", "@id908764",
        "@moiID","@NikitaKrut","@id2281137","@id968123","@id1234321","@id654321","@id1234756"};

        /// <summary>
        /// 
        /// </summary>
        private static string[] _fullName = new string[40];

        /// <summary>
        /// Генерирует рандомное число
        /// </summary>
        /// <param name="lengthOfArray"></param>
        /// <param name="randomNumber"></param>
        /// <returns></returns>
        private static int GenerateNumber(int lengthOfArray, Random randomNumber)
        {
            return randomNumber.Next(lengthOfArray);
        }

        /// <summary>
        /// Метод гененрации случайного контакта
        /// </summary>
        /// <returns></returns>
        public static List<Contact> GenerateRandomContactsName()
        {
            string[] fullNameArray = new string[20];

            for (int i = 0; i <= 10; i++)
            {
                fullNameArray[i] =
                $"{_arrMaleSurname[GenerateNumber(_arrMaleSurname.Length, _random)]} "+
                $"{_arrMaleName[GenerateNumber(_arrMaleName.Length, _random)]} " +
                $"{_arrMalePatronymic[GenerateNumber(_arrMalePatronymic.Length, _random)]} ";
            }
            for (int i = 11; i < 20; i++)
            {
                fullNameArray[i] =
                $"{_arrFemaleSurname[GenerateNumber(_arrFemaleSurname.Length, _random)]} " +
                $"{_arrFemaleName[GenerateNumber(_arrFemaleName.Length, _random)]} " +
                $"{_arrFemalePatronymic[GenerateNumber(_arrFemalePatronymic.Length, _random)]} ";
            }
            for (int i = 0; i < 20; i++)
            {   
                Contact contact = new Contact
                (fullNameArray[i],
                _arrEmail[GenerateNumber(_arrEmail.Length, _random)],
                _arrPhoneNumber[GenerateNumber(_arrPhoneNumber.Length, _random)], 
                DateTime.Today,
                _arrIDVk[GenerateNumber(_arrIDVk.Length, _random)]);
                _project.Contacts.Add(contact);
            }
            return _project.Contacts;
        }
    }
}
