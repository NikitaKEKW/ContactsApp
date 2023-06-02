using System;
using System.IO;
using static System.Environment;
using Newtonsoft.Json;

namespace ContactsApp.Model
{
    public static class ProjectSerializer
    {
        /// <summary>
        /// Поле хранящая путь до файла
        /// </summary>
        public static string Directoryname = GetFolderPath(SpecialFolder.ApplicationData)
            + @"\Danilik\ContactsApp";

        /// <summary>
        /// Поле хранящее путь до файла и его название
        /// </summary>
        public static string Filename = Directoryname + @"\userdata.json";

        /// <summary>
        /// Метод реализующий сохранение данных в json файл
        /// </summary>
        /// <param name="project"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void SaveToFile(Project project)
        {
            if (!Directory.Exists(Directoryname))
            {
                Directory.CreateDirectory(Directoryname);
                if (!File.Exists(Filename))
                {
                    FileStream fileWithDataContacts = new FileStream(Filename, FileMode.Create);
                }
            }
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary> 
        /// Метод реализущий чтение данных с json файла
        /// </summary>
        /// <returns></returns>
        public static Project LoadFromFile()
        {
            Project project = new Project();
            if (!File.Exists(Filename))
            {
                return project;
            }
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader streamReader = new StreamReader(Filename))
                using (JsonReader reader = new JsonTextReader(streamReader))
                    if (reader == null)
                    {
                        return project;
                    }
                    else
                    {
                        project = serializer.Deserialize<Project>(reader);

                        if (project == null)
                        {
                            return new Project();
                        }
                        return project;
                    }
            }
            catch
            {
                return project;
            }
        }
    }
}
