using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Books;

namespace BookService
{
    //  WCF self-hosted service in a console application which allows to see all the books in the library, add new book, update book price.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class BookService : IBookService
    {
        List<Book> books = new List<Book>();
        public void AddBook(Book b)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (b.ID == books[i].ID)
                {
                    Console.WriteLine("ID's cannot be repeated");
                    return;
                }
            }
            books.Add(b);
            Console.WriteLine("Added");
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public void UpdatePrice(int ID, double price)
        {
            if (books.Count(c => c.ID == ID) != 1)
            {
                Console.WriteLine("That book doesn't exist in our collection");
                return;
            }
            for (int i = 0; i < books.Count; i++)
            {
                if (ID == books[i].ID)
                {
                    books[i].price = price;
                }
            }

        }
    }
}
