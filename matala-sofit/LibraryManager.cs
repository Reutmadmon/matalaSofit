using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace matala_sofit
{
    public class LibraryManager : Employee, IUserOperations
    {
        private char Type = 'M';

        public LibraryManager(string name, string lastName, int id, string password, int age, int phoneNum,
                              string email, string photo, int empId, Library library)
            : base(name, lastName, id, password, age, phoneNum, email, photo, empId, library)
        {
        }

        public void SendMessage(Message message, Person person)
        {
            person.AddMessage(message);
        }

        public void AddBook(Book book, List<Book> books)
        {
            if (book != null && !books.Contains(book))
            {
                books.Add(book);
            }
        }

        public void RemoveBook(Book book, List<Book> books)
        {
            if (book != null && books.Contains(book))
            {
                books.Remove(book);
            }
        }

        public void BorrowBook(Book book, int id)
        {
            Client client = library.Clients.FirstOrDefault(c => c.Id == id);
            client.BorrowBook(book);
        }

        public void ReturnBook(Book book, int id)
        {
            Client client = library.Clients.FirstOrDefault(c => c.Id == id);
            client.ReturnBook(book);
        }

        public void AddGenre(Genre genre, List<Genre> genres)
        {
            if (genre != null && !genres.Contains(genre))
            {
                genres.Add(genre);
            }
        }

        public void RemoveGenre(Genre genre, List<Genre> genres)
        {
            if (genre != null && genres.Contains(genre))
            {
                genres.Remove(genre);
            }
        }

        public void AddEmployee(List<Employee> employees, string name, string lastName, int id, string password, int age, int phoneNum, string email, string photo,
                        int empId)
        {
            if (Type.Equals('L'))
            {
                employees.Add(new Librarian(name, lastName, id, password, age, phoneNum, email, photo, empId, library));
                WritePassword(id, password, "L");
            }
            else if (Type.Equals('S'))
            {
                employees.Add(new ShelfStocker(name, lastName, id, password, age, phoneNum, email, photo, empId, library));
                WritePassword(id, password, "S");
            }
            else
            {
                throw new Exception("Invalid employee type.");
            }
        }

        public void WritePassword(int id, string pass, string type)
        {
            string Path = "passwords.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(Path, true))
                {
                    sw.WriteLine($"{id}:{pass}:{type}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }

        public void RemoveEmployee(List<Employee> employees, Employee employee)
        {
            if (employee != null && employees.Contains(employee))
            {
                employees.Remove(employee);
            }
        }

        public void AddClient(List<Client> clients, Client client)
        {
            if (client != null && !clients.Contains(client))
            {
                clients.Add(client);
            }
        }

        public void RemoveClient(List<Client> clients, Client client)
        {
            if (client != null && clients.Contains(client))
            {
                clients.Remove(client);
            }
        }

        public override string ToString()
        {
            return "Library Manager:\n" + base.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is LibraryManager other && this.EmpId == other.EmpId;
        }
    }
}
