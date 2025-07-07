using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace matala_sofit
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Client> Clients { get; set; } = new List<Client>();
        //wait list?

        public Library() { }

        public static void SaveToFile<T>(string filePath, List<T> data)
        {
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<T> LoadFromFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<T>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<T>>(json);
        }

        public void WriteData(List<Book> books, List<Genre> genres, List<Employee> employees, List<Client> clients)
        {
            SaveToFile("books.json", books);
            SaveToFile("genres.json", genres);
            SaveToFile("employees.json", employees);
            SaveToFile("clients.json", clients);
        }

        public void ReadData(List<Book> books, List<Genre> genres, List<Employee> employees, List<Client> clients)
        {
            books = LoadFromFile<Book>("books.json");
            genres = LoadFromFile<Genre>("genres.json");
            employees = LoadFromFile<Employee>("employees.json");
            clients = LoadFromFile<Client>("clients.json");
        }
    }
}
