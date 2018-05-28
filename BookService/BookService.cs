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
    [DataContract] //
    public class BookService : IBookService
    {
        static List<Book> books = new List<Book>();
        public Result AddBook(Book b)
        {
            Result res = new Result();
            for (int i = 0; i < books.Count; i++)
            {
                if (b.ID == books[i].ID)
                {
                    res.Status = "Fail";
                    res.Message = "ID's cannot be repeated";
                    return res;
                }
            }
            books.Add(b);
            res.Status = "Success";
            res.Message = "Added";
            return res;
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public Result UpdatePrice(int ID, double newPrice)
        {
            Result res = new Result();
            var currentBook = books.FirstOrDefault(c => c.ID == ID);
            if (currentBook is null)
            {
                res.Status = "Fail";
                res.Message = "That book doesn't exist in our collection";
                return res;
            }
            res.Status = "Success";
            res.Message = "Updated";
            currentBook.price = newPrice;
            return res;
        }
    }
}