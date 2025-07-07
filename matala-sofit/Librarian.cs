using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public class Librarian : Employee, IUserOperations
    {
        internal Librarian(string name, string lastName, int id, string password, int age, int phoneNum,
                         string email, string photo,
                         int empId, Library library)
            : base(name, lastName, id, password, age, phoneNum, email, photo, empId, library)
        {
        }

        public List<Book> MostPopularBookReport()
        {
            List<Book> popularBooks = new List<Book>();
            foreach (Book book in library.Books)
            {
                if (book.CalcRating() >= 4.5)
                {
                    popularBooks.Add(book);
                }
            }
            return popularBooks;
        }

        public void SendMessage(Message message, Client client)
        {
            if (client == null) throw new ArgumentNullException("this client does not exist");
            client.AddMessage(message);
        }

        public void EditClient(Client c, string name = null, string lastName = null, int id = 0,
            string password = null, int age = 0, int phoneNum = 0, string email = null, string photo = null)
        {
            if (c == null) throw new ArgumentNullException("this client does not exist");
            if (name != null) c.Name = name;
            if (lastName != null) c.LastName = lastName;
            if (id != 0) c.Id = id;
            if (password != null) c.Password = password;
            if (age != 0) c.Age = age;
            if (phoneNum != 0) c.PhoneNum = phoneNum;
            if (email != null) c.Email = email;
            if (photo != null) c.Photo = photo;
        }

        public void EditBook(Book book, string title = null, string author = null, int bookId = 0, Genre genre = null, int copies = 0,
            string locationOnShelf = null, string photo = null)
        {
            if (book == null) throw new ArgumentNullException("this book does not exist");
            if (title != null) book.Title = title;
            if (author != null) book.Author = author;
            if (bookId != 0) book.BookId = bookId;
            if (genre != null) book.Genre = genre;
            if (copies != 0) book.Copies = copies;
            if (locationOnShelf != null) book.LocationOnShelf = locationOnShelf;
            if (photo != null) book.Photo = photo;
        }

        public void CalcDebt()
        {
            int finePerWeek = 30;
            int finePerDay = 10;
            double totalDebt = 0;

            foreach (Client client in library.Clients)
            {
                foreach (Message m in client.Messages)
                {
                    if(m.Type==MessageType.OverdueBookNotice)
                }//implement 
            }
        }

        public void AddClient(string name, string lastName, int id, string password, int age, int phoneNum,
                       string email, string photo)
        {
            library.Clients.Add(new Client(name, lastName, id, password, age, phoneNum, email, photo));
        }

        public void RemoveClient(int id)
        {
            Client client = library.Clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
            {
                throw new Exception("Client does not exist.");
            }
            library.Clients.Remove(client);
        }

        public void SendMessage(Message message, int id)
        {
            Client client = library.Clients.FirstOrDefault(c => c.Id == id);
            Employee employee = library.Employees.FirstOrDefault(e => e.Id == id);

            Person person = client != null ? client : employee;
            if (person == null)
            {
                throw new Exception("Person with the given ID does not exist.");
            }
            person.AddMessage(message);
        }

        public void BorrowBook(Book book, int id)
        {
            Client client = library.Clients.FirstOrDefault(c => c.Id == id);
            client.BorrowBook(book,);
        }

        public void ReturnBook(Book book, int id)
        {
            Client client = library.Clients.FirstOrDefault(c => c.Id == id);
            client.ReturnBook(book);
        }

        public override string ToString()
        {
            return base.ToString() + $", On Shift: {OnShift}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Librarian other)
                return base.Equals(other) && this.EmpId == other.EmpId;
            return false;
        }
    }
}
