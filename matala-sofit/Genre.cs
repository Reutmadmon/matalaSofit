using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;

namespace matala_sofit
{
    public class Genre
    {
        public string Name { get; set; }
        public string AgeRestriction { get; set; }
        public string ShortDescription { get; set; }
        public List<Book> Books { get; set; }

        public Genre(string name, string ageRestriction, string description)
        {
            this.Name = name;
            this.AgeRestriction = ageRestriction;
            this.ShortDescription = description;
        }

        public override string ToString()
        {
            string bookTitles = Books != null && Books.Count > 0
                ? string.Join(", ", Books.Select(b => b.Title))
                : "No books";

            return $"Genre: {Name}\n" +
                   $"Age Restriction: {AgeRestriction}\n" +
                   $"Description: {ShortDescription}\n" +
                   $"Books: {bookTitles}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Genre other)
                return this.Name == other.Name;
            return false;
        }
    }
}
