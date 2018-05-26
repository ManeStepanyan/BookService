using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    [DataContractAttribute] // to let serialization
    public class Book
    {   [DataMember]
        public int ID;
        [DataMember]
        public string author;
        [DataMember]
        public string title;
        [DataMember]
        public double price;
        [DataMember]
        public int year;
        public Book(int ID, string author, string title, double price, int year)
        {
            this.ID = ID;
            this.author = author;
            this.title = title;
            this.price = price;
            this.year = year;
        }
    }
}
