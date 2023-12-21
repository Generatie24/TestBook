using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBook
{
    public static class StaticData
    {
        public static List<Book> BooksCollection { get; set; }

        static StaticData()
        {
            BooksCollection = new List<Book>(); // Initialiseren van de books-lijst in de constructor
        }

        public static List<Book> Books()
        {
            // Voeg enkele boeken toe
            BooksCollection.Add(new Book { ID = 1, Name = "Book1" });
            BooksCollection.Add(new Book { ID = 2, Name = "Book2" });
            BooksCollection.Add(new Book { ID = 3, Name = "Book3" });
            BooksCollection.Add(new Book { ID = 4, Name = "Book4" });
            return BooksCollection;
        }
    }
}
