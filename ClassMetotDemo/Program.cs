using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Ad = "Buğrahan";
            customer1.Soyad = "Gökçe";
            customer1.Yas = 20;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Ad = "Bahtiyar";
            customer2.Soyad = "Korkmaz";
            customer2.Yas = 22;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Ad = "Ece";
            customer3.Soyad = "Yılmaz";
            customer3.Yas = 18;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine("Müşteri Id'si : " + customer.Id);
                Console.WriteLine("Müşteri İsmi : " + customer.Ad);
                Console.WriteLine("Müşteri Soyismi : " + customer.Soyad);
                Console.WriteLine("Müşteri Yaşı : " + customer.Yas);
                Console.WriteLine("----------------");
            }

            CustomerManager customerManager = new CustomerManager();

            customerManager.CustomerAdd(customer1);
            customerManager.CustomerDelete(customer2);
            customerManager.CustomerList(customer1);
            customerManager.CustomerList(customer2);
            customerManager.CustomerList(customer3);

            Console.ReadLine();
        }
    }
}
