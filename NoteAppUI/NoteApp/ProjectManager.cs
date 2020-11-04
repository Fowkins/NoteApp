using System.IO;
using Newtonsoft.Json;
namespace NoteApp
{
    /// <summary>
    /// Класс, отвечающий за сериализацию заметок
    /// </summary>
    public class ProjectManager
    {
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

    }
}