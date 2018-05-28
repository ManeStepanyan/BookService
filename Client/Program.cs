using Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book(1, "Dan Brown", "Inferno", 5560, 2013);
            Book b1 = new Book(2, "Keys", "Flowers for Algernon", 750, 2011);
            Book b2 = new Book(3, "oo", "aa", 50, 1011);
            var client = new Test.BookServiceClient();
            client.AddBook(b);
            client.AddBook(b1);
            client.AddBook(b2);
            List<Book> currentBooks = client.GetBooks().ToList();
            for (int i = 0; i < currentBooks.Count; i++)
            {
                Console.WriteLine("ID is {0}, Author is {1}, Title is {2}, Price is {3}, Release year is {4}", currentBooks[i].ID, currentBooks[i].author, currentBooks[i].title, currentBooks[i].price, currentBooks[i].year);
            }
            var result = client.UpdatePrice(1, 800);
            Console.WriteLine(result.Message);
            currentBooks = client.GetBooks().ToList();
            for (int i = 0; i < currentBooks.Count; i++)
            {
                Console.WriteLine("ID is {0}, Author is {1}, Title is {2}, Price is {3}, Release year is {4}", currentBooks[i].ID, currentBooks[i].author, currentBooks[i].title, currentBooks[i].price, currentBooks[i].year);
            }

            Console.ReadKey();
        }
    }
}
