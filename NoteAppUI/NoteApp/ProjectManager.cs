using System;
using System.IO;
using Newtonsoft.Json;
namespace NoteApp
{
    /// <summary>
    /// Класс, отвечающий за сериализацию заметок
    /// </summary>
    public class ProjectManager
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\NoteApp.notes";  //Закрытая константа, содержащая путь 
        public static void SaveToFile(Project data, string file)
        {
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };

            using (StreamWriter sw = new StreamWriter(file))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }

        /// <summary>
        /// Сохранения списка заметок в путь по умолчанию
        /// </summary>
        /// <param name="data">Список заметок</param>
        public static void SaveToFile(Project data)
        {
            SaveToFile(data, _path);
        }

        public static Project LoadFromFile(string file)
        {
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };

            using (StreamReader sr = new StreamReader(file))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (Project)serializer.Deserialize<Project>(reader);
            }
        }

        /// <summary>
        /// Загрузка списка из файла в путь по умолчанию
        /// </summary>
        /// <returns>Возвращает список заметок</returns>
        public static Project LoadFromFile()
        {
            return LoadFromFile(_path);
        }

    }
}