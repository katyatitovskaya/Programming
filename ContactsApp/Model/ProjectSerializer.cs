using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContactsApp.Model
{
    public static class ProjectSerializer
    {
        /// <summary>
        /// Сохраняет данные в файл. 
        /// </summary>
        /// <param name="contacts"></param>
        /// <param name="directoryPath">Путь к файлу <see cref="fileName"/>. </param>
        /// <param name="fileName">Файл, в котором будут сохранены данные. </param>
        public static void SaveToFile(List<Contact> contacts, string directoryPath, string fileName)
        {
            if(!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string contactsString = JsonSerializer.Serialize(contacts);
            File.WriteAllText($"{directoryPath}/{fileName}", contactsString);
        }

        /// <summary>
        /// Загружает данные из файла. 
        /// </summary>
        /// <param name="directoryPath">Путь к файлу <see cref="fileName"/>. </param>
        /// <param name="fileName">Файл, из которого будут загружены данные. </param>
        /// <returns>Возвращает список загруженных данных. </returns>
        public static List<Contact> LoadFromFile(string directoryPath,string fileName)
        {
            List<Contact> contacts = new List<Contact>();
            if(File.Exists($"{directoryPath}/{fileName}"))
            {
                var contactsString = File.ReadAllText($"{directoryPath}/{fileName}");
                contacts = JsonSerializer.Deserialize<List<Contact>>(contactsString);
            }
            return contacts;
        }
    }
}
