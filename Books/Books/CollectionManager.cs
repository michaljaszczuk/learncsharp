using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Books
{

    class CollectionManager
    {
        public List<Book> bookList = new List<Book>();
                  
        
        public List<Book> PrintCollection(List<Book> bookList)
        {
            bookList.ForEach(Console.WriteLine);
            return bookList;           
            
        }


        public List<Book> AddToCollection(int id)
        {

            
            string addBookAnswer;

            do
            {

                Console.WriteLine("\t \t Add a book to collecton: ");

                Console.WriteLine("Enter author name: ");
                string aname = Console.ReadLine();

                Console.WriteLine("Enter title: ");
                string bookTitle = Console.ReadLine();

                Console.WriteLine("Enter ISBN number: ");
                string isbnStr = Console.ReadLine();

                int isbnInt;
                Int32.TryParse(isbnStr, out isbnInt);                             

                bookList.Add(new Book(id, aname, bookTitle, isbnInt));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Book succesfully added with id: {0}", id++);
                Console.ResetColor();
                Console.WriteLine("Do you want to add another book? [y] for Yes, [n] for No.");
                addBookAnswer = Console.ReadLine();

                if (addBookAnswer == "n")
                {
                    Console.WriteLine("This is your collection of books: ");
                    break;
                }
                else 
                {
                
                    continue;
                }
                
            }
            while (addBookAnswer == "y");
            

            return bookList;
                   

        }

        public List<Book> RemoveFromCollection()
        {

            


            Console.WriteLine("Enter ID of book you want to remove: ");

            string toRemoveStr = Console.ReadLine();

            int intToRemove;
            Int32.TryParse(toRemoveStr, out intToRemove);

            
            bookList.RemoveAll(x => x.ID == intToRemove);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Item removed successfully. ");
            Console.ResetColor();
            return bookList;
        }


        public List<Book> ListToCSV(List<Book> bookList)
        {

            string csvFile = "booklist.csv";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter
                   (@"C:\Users\micha\source\repos\Books\Books\Data\" + csvFile, false, System.Text.Encoding.GetEncoding("utf-8")))
            {
                //robi za tytuly kolumn
                file.WriteLine("ID, Author, Title, ISBN");

                
                foreach (Book element in bookList)
                {
                    file.WriteLine("{0},{1},{2},{3}", element.ID, element.Author, element.Title, element.ISBN);
                }
            }

            Console.WriteLine("Your collection has been saved as: {0}", Path.GetFileName(csvFile));
            string pathToFile = Path.Combine(Environment.CurrentDirectory, @"Data\", csvFile);
            Console.WriteLine("Location: {0}", pathToFile);
            return bookList;

        }

    }
        


        

        
        


   

    
}
