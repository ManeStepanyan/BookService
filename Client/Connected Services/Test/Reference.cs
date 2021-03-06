﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Test {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Test.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBooks", ReplyAction="http://tempuri.org/IBookService/GetBooksResponse")]
        Books.Book[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBooks", ReplyAction="http://tempuri.org/IBookService/GetBooksResponse")]
        System.Threading.Tasks.Task<Books.Book[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        BookService.Result AddBook(Books.Book b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        System.Threading.Tasks.Task<BookService.Result> AddBookAsync(Books.Book b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdatePrice", ReplyAction="http://tempuri.org/IBookService/UpdatePriceResponse")]
        BookService.Result UpdatePrice(int ID, double price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdatePrice", ReplyAction="http://tempuri.org/IBookService/UpdatePriceResponse")]
        System.Threading.Tasks.Task<BookService.Result> UpdatePriceAsync(int ID, double price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : Client.Test.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<Client.Test.IBookService>, Client.Test.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Books.Book[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<Books.Book[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public BookService.Result AddBook(Books.Book b) {
            return base.Channel.AddBook(b);
        }
        
        public System.Threading.Tasks.Task<BookService.Result> AddBookAsync(Books.Book b) {
            return base.Channel.AddBookAsync(b);
        }
        
        public BookService.Result UpdatePrice(int ID, double price) {
            return base.Channel.UpdatePrice(ID, price);
        }
        
        public System.Threading.Tasks.Task<BookService.Result> UpdatePriceAsync(int ID, double price) {
            return base.Channel.UpdatePriceAsync(ID, price);
        }
    }
}
