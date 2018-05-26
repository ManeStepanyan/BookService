using Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookService
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        List<Book> GetBooks(); // Get all the books from the collection
        [OperationContract]
        void AddBook(Book b); // Add any book
        [OperationContract]
        void UpdatePrice(int ID, double price); // update price of the book

    }
}
