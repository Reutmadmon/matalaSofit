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
        internal Genre section { get; set; }

        public ShelfStocker(string name, string lastName, int id, string password, int age, int phoneNum, string email, string photo,
                        int empId, bool onShift, Genre section)
            : base(name, lastName, id, password, age, phoneNum, email, photo, empId,onShift)
        {
            this.section = section;
        }
        public String GetLocationByBook(Book book)
        {
            return $"section:{book.genre}, location: {book.locationOnShelf}";
        }
        //remove book from  books.FirstOrDefault(b => b.Location == location);
        public void changeLocation(string newLocation, Book book)
        {
            book.locationOnShelf = newLocation;
        }

        public override string ToString()
        {
            return "Shelf Stacker: " + base.ToString()+ $", Section: {section}";
        }
        public override bool Equals(object obj)
        {
            if (obj is ShelfStocker other)
                return base.Equals(other);
            return false;
        }
    }
}
