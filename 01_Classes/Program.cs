using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ahmet";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Hasan",
                LastName = "Ozturk"
            };

            Console.WriteLine(customer2.FirstName);
               

            Console.ReadLine();
        }
    }

    
   
}
