using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace matala_sofit
{
    public class ShelfStocker : Employee
    {
        public Genre Section { get; set; }

        internal ShelfStocker(string name, string lastName, int id, string password, int age, int phoneNum, string email, string photo,
                        int empId,Library library)
            : base(name, lastName, id, password, age, phoneNum, email, photo, empId, library)
        {
        }
        //public String GetLocationByBook(string bookName)//לפי מחרוזת
        //{
        //    Book b= library.books.FirstOrDefault(b => b.title == bookName);
        //    return $"section:{b.genre}, location: {b.locationOnShelf}";
        //}
        public void ChangeLocation(string newLocation, Book book)
        {
            book.locationOnShelf = newLocation;
        }
        //reshelfing
        public override string ToString()
        {
            return "Shelf Stacker: " + base.ToString()+ $", Section: {Section}";
        }
        public override bool Equals(object obj)
        {
            if (obj is ShelfStocker other)
                return base.Equals(other);
            return false;
        }
    }
}
