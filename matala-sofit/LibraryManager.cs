using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public class LibraryManager: Employee
    {
        private List<Book> books{get;set; } = new List<Book>();
        private List<Genre> genres { get; set; } = new List<Genre>();
        private List<Employee> employees { get; set; } = new List<Employee>();
        private List<Client> clients { get; set; } = new List<Client>();


        public LibraryManager(string name, string lastName, int id, string password, int age, int phoneNum,
                              string email, string photo, int empId, bool onShift)
            : base(name, lastName, id, password, age, phoneNum, email, photo, empId, onShift)
        {
       
        }
        public void sendMessage(Message message, Person person)
        {
            person.addMessage(message);
        }

        public void addBook(Book book)
        {
            if (book != null && !books.Contains(book))
            {
                books.Add(book);
            }
        }
        public void removeBook(Book book)
        {
            if (book != null && books.Contains(book))
            {
                books.Remove(book);
            }
        }
       
        public void addGenre(Genre genre)
        {
            if (genre != null && !genres.Contains(genre))
            {
                genres.Add(genre);
            }
        }
        public void removeGenre(Genre genre)
        {
            if (genre != null && genres.Contains(genre))
            {
                genres.Remove(genre);
            }
        }

        public void addEmployee(Employee employee)
        {
            if (employee != null && !employees.Contains(employee))
            {
                employees.Add(employee);
            }
        }
        public void removeEmployee(Employee employee)
        {
            if (employee != null && employees.Contains(employee))
            {
                employees.Remove(employee);
            }
        }
        public void addClient(Client client)
        {
            if (client != null && !clients.Contains(client))
            {
                clients.Add(client);
            }

        }
        public void removeClient(Client client)
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
            return obj is LibraryManager other && this.empId == other.empId;
        }

        //        public List<Book> GetBooks() => books;
        //        public List<Genre> GetGenres() => genres;
        //        public List<Employee> GetEmployees() => employees;
    }
}
