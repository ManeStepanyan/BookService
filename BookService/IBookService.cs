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
       Result AddBook(Book b); // Add any book
        [OperationContract]
       Result UpdatePrice(int ID, double price); // update price of the book

    }
    [DataContract]
    public class Result
    {
        string message;
        string status;

        [DataMember]
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        [DataMember]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
