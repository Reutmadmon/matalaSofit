using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int BookId { get; set; }
        public Genre Genre { get; set; }
        public int Copies { get; set; }
        public string LocationOnShelf { get; set; }
        public Client[] Clients { get; set; }
        public string Photo { get; set; }
        public int[] Rating { get; set; } // מערך מונים מ0-4 חמישה כוכבים
        public string Description { get; set; }

        public Book(string title, string author, int bookId, Genre genre, int copies,
            string locationOnShelf, string photo)
        {
            this.Title = title;
            this.Author = author;
            this.BookId = bookId;
            this.Genre = genre;
            genre.Books.Add(this); // add to genre list
            this.Copies = copies;
            this.LocationOnShelf = locationOnShelf;
            this.Photo = photo;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Book ID: {BookId}, Genre: {Genre}, " +
                   $"Copies: {Copies}, Location on Shelf: {LocationOnShelf}, Available: {(Copies > 0 ? "Yes" : "No")}";
        }

        public double CalcRating()
        {
            int sum = 0;
            int countReaders = 0;

            for (int i = 0; i < this.Rating.Length; i++)
            {
                countReaders += this.Rating[i];
                sum += (i + 1) * this.Rating[i];
            }

            return sum / (double)countReaders;
        }

        public override bool Equals(object obj)
        {
            if (obj is Book other)
            {
                return this.BookId == other.BookId;
            }
            return false;
        }
    }
}
