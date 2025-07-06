using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala_sofit
{
    public class Book
    {
        internal string title { get; set; }
        internal string author { get; set; }
        internal int bookId { get; set; }//add better set
        internal Genre genre { get; set; }
        internal int copies { get; set; }
        internal string locationOnShelf { get; set; }
        internal Client[] clients { get; set; }
        internal string photo {  get; set; }
        internal int[] rating { get; set; }

        //אין צורך בנגיש להשאלה פשוט מורידים את מס העותקים

            public Book(string title, string author, int bookId, Genre genre, int copies, 
            string locationOnShelf, string photo)
        {
            this.title = title;
            this.author = author;
            this.bookId = bookId;
            this.genre = genre;
            this.copies = copies;
            this.locationOnShelf = locationOnShelf;
            this.photo = photo;
        }
    
        public override string ToString()
        {
            return $"Title: {title}, Author: {author}, Book ID: {bookId}, Genre: {genre}," +
                $" Copies: {copies}, Location on Shelf: {locationOnShelf}, Available: {(copies > 0 ? "Yes" : "No")}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Book other)
            {
                return this.bookId == other.bookId; 
            }
            return false;
        }

        public double calcRating()
        {
            //to do
        }

    }
}
