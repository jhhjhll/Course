using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Course;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Course
{
    public class JSON
    {
        private readonly string filePart;

        public JSON(string fileName = "countries.json")
        {
            filePart = Path.Combine(Application.StartupPath, fileName);
        }

        //завантаження інформації з файлу
        public List<Country> LoadCountries()
        {
            if (!File.Exists(filePart)) return new List<Country>();

            string jsonData = File.ReadAllText(filePart);

            if (string.IsNullOrWhiteSpace(jsonData)) return new List<Country>();

            return JsonConvert.DeserializeObject<List<Country>>(jsonData);
        }
        //збереження інформації
        public bool SaveCountries(List<Country> countries)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                StringEscapeHandling = StringEscapeHandling.Default,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            string JsonData = JsonConvert.SerializeObject(countries, settings);
            File.WriteAllText(filePart, JsonData);
            return true;
        }
    }
}
