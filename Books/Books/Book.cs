using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Books
{
    class Book
    {
        /*private static int ID = 0;

        public int BookId { get; private set; }*/

        public int ID { get; set; }

        public string Author { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }

        public List<Book> MyList { get; set; }

        public Book(int id, /*int BookId,*/ string author, string title, int isbn)
        {
            /*this.BookId = BookId;
            this.BookId = Interlocked.Increment(ref ID);*/
            ID = id;
            Author = author;
            Title = title;
            ISBN = isbn;
        }
        public string sep = " | ";

        public override string ToString()
           
        {
            return ID + ". "  + sep + "Author: " + Author + sep +  " Title: " +  Title + sep +  " ISBN: " + ISBN;
            
        }

    }
}
