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
        internal string name { get; set; }
        internal string ageRestriction { get; set; }
        internal string shortDescription { get; set; }
        internal Book[] books { get; set; }
        public Genre(string name, string ageRestriction, string description, Book[] books)
        {
            this.name = name;
            this.ageRestriction = ageRestriction;
            this.shortDescription = description;
            this.books = books;
        }
        
        public override string ToString()
        {
            string bookTitles = books != null && books.Length > 0
                ? string.Join(", ", books.Select(b => b.title))
                : "No books";

            return $"Genre: {name}\n" +
                   $"Age Restriction: {ageRestriction}\n" +
                   $"Description: {shortDescription}\n" +
                   $"Books: {bookTitles}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Genre other)
                return this.name == other.name;
            return false;
        }

    }
}
