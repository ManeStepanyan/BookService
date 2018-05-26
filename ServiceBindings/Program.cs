using BookService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBindings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVICE";
            Uri address = new Uri("http://192.168.2.252:5901/IBookService");
            WSHttpBinding binding = new WSHttpBinding();
            ServiceHost host = new ServiceHost(typeof(BookService.BookService), address);
            host.AddServiceEndpoint(typeof(IBookService), binding, address);
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true; /// 
            host.Description.Behaviors.Add(smb);
            host.Open();
            Console.WriteLine("Press <ENTER> to terminate service.");
            Console.WriteLine();
            Console.ReadLine();

            // Close the host to shutdown the service.  
            host.Close();

        }
    }
}
