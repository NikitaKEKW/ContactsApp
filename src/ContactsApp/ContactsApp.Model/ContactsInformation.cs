using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class ContactsInformation
    {
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
        /// Массив дней рождений
        /// </summary>
        private static string[] _arrDateOfBirth = { };

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
        /// 
        /// </summary>
        /// <param name="_rnd"></param>
        /// <param name="lengthOfArray"></param>
        /// <returns></returns>
        private static int GenerateDigit(Random _rnd, int lengthOfArray)
        {
            return _rnd.Next(lengthOfArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_rnd"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        public static List<Contact> GenerateRandomContactsName(Random _rnd, Project project)
        {
            for (int i = 0; i <= 10; i++)
            {
                _fullName[i] = _arrMaleSurname[GenerateDigit(_rnd, _arrMaleSurname.Length)] + " " +
                _arrMaleName[GenerateDigit(_rnd, _arrMaleName.Length)] + " "
                + _arrMalePatronymic[GenerateDigit(_rnd, _arrMalePatronymic.Length)];

            }
            for (int i = 11; i < 20; i++)
            {
                _fullName[i] = _arrFemaleSurname[GenerateDigit(_rnd, _arrFemaleSurname.Length)] + " " +
                _arrFemaleName[GenerateDigit(_rnd, _arrFemaleName.Length)] + " "
                + _arrFemalePatronymic[GenerateDigit(_rnd, _arrFemalePatronymic.Length)];

            }
            for (int i = 0; i < 20; i++)
            {
                Contact contact = new Contact(_fullName[GenerateDigit(_rnd, _fullName.Length)],
                _arrEmail[GenerateDigit(_rnd, _arrEmail.Length)],
                _arrPhoneNumber[GenerateDigit(_rnd, _arrPhoneNumber.Length)], DateTime.Today,
                _arrIDVk[GenerateDigit(_rnd, _arrIDVk.Length)]);
                project.Contacts.Add(contact);
            }
            return project.Contacts;
        }
    }
}
