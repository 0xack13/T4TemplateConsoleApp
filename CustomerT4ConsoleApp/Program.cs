using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerT4ConsoleApp
{
    public class Customer
    {
        public string Name { get; set; }
        public DateTime LastLoginDate { get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Initialize the customer information
            var customer = new Customer
            {
                Name = "Jeffery",
                LastLoginDate = new DateTime(2014, 11, 2, 19, 23, 32)
            };

            //Using the T4 template
            var template = new EmailTemplate();
            template.Session = new Dictionary<string, object>()
            {
                { "Customer", customer }
            };

            template.Initialize();
            Console.WriteLine(template.TransformText());
            Console.ReadLine();
        }
    }
}
