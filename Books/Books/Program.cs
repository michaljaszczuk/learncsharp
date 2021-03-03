using System;
using System.Collections.Generic;

namespace Books
{
    class Program
    {

        const int id = 1;
        static void Main(string[] args)
        {
            CollectionManager collectionManager = new CollectionManager();
            /*collectionManager.PrintCollection(collectionManager.bookList);*/

            collectionManager.AddToCollection(id);

            collectionManager.PrintCollection(collectionManager.bookList);

            collectionManager.RemoveFromCollection();

            collectionManager.PrintCollection(collectionManager.bookList);

            collectionManager.ListToCSV(collectionManager.bookList);





        }
    }
}
