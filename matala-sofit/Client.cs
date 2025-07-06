using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public class Client : Person
    {
        List<Book> booksBorrows { get; set; } = new List<Book>();
        List<Book> booksHistory { get; set; } = new List<Book>();
        //private double debt{get;set; } to think about how
       
        public Client(string name, string lastName, int id,string password, int age, int phoneNum,
                       string email, string photo)
           : base(name, lastName, id, password, age, phoneNum, email, photo)
        {

        }
        public void BorrowBook(Book book)
        {
            if (book != null && !booksBorrows.Contains(book))
            {
                booksBorrows.Add(book);
            }
            else
            {
                throw new Exception("Book is already borrowed or does not exist.");
            }
        }
        public void ReturnBook(Book book)
        {
            if (book != null && booksBorrows.Contains(book))
                booksBorrows.Remove(book);
            if (!booksHistory.Contains(book))
            {
                booksHistory.Add(book);
            }
    }

        public override bool Equals(object obj)
        {
            if (obj is Client other)
                return base.Equals(other);
            return false;
        }

        public override string ToString()
        {
            string borrows = booksBorrows != null && booksBorrows.Count > 0
                ? string.Join(", ", booksBorrows)
                : "None";

            string history = booksHistory != null && booksHistory.Count > 0
                ? string.Join(", ", booksHistory)
                : "None";

            return base.ToString() + "\n" +
                    $"Books Borrowed: {borrows}\n" +
                    $"Books History: {history}";
        }
    }
}
