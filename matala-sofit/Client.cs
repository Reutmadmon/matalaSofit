using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public class Client : Person, IUserOperations
    {
        List<Book> BooksBorrowed { get; set; } = new List<Book>();
        List<Book> BooksHistory { get; set; } = new List<Book>();
        List<Book> Favorites { get; set; } = new List<Book>();
        //חוב

        public Client(string name, string lastName, int id, string password, int age, int phoneNum,
                       string email, string photo)
           : base(name, lastName, id, password, age, phoneNum, email, photo)
        {
        }

        public void BorrowBook(Book book, int id) //finish this method
        {
            if (book != null && !BooksBorrowed.Contains(book))
            {
                BooksBorrowed.Add(book);
                //שולח לו הודעה עם פרטים על תאריך  וזמן החזרה ואיזה ספר
                //הספר לא יהיה במערך הספרים של הספרייה
                //להוסיף למערך ההיסטוריה של הלקוח
            }
            else
            {
                throw new Exception("Book is already borrowed or does not exist.");
            }
        }

        public void ReturnBook(Book book, int id) //finish this method
        {
            if (book != null && BooksBorrowed.Contains(book))
                BooksBorrowed.Remove(book);
            if (!BooksHistory.Contains(book))
            {
                BooksHistory.Add(book);
            }
            // להוסיף למערך ההחזרה של הסדרן
            // הספר יחזור למערך הספרים של הספרייה
        }

        //הוספת ספר למועדפים

        public override bool Equals(object obj)
        {
            if (obj is Client other)
                return base.Equals(other);
            return false;
        }

        public override string ToString()
        {
            string borrows = BooksBorrowed != null && BooksBorrowed.Count > 0
                ? string.Join(", ", BooksBorrowed)
                : "None";

            string history = BooksHistory != null && BooksHistory.Count > 0
                ? string.Join(", ", BooksHistory)
                : "None";

            return base.ToString() + "\n" +
                    $"Books Borrowed: {borrows}\n" +
                    $"Books History: {history}";
        }
    }
}
