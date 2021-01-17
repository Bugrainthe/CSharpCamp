using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi : " + customer.Ad + " " +customer.Soyad);
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi : " + customer.Ad + " " + customer.Soyad);
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine("Müşteri Listelendi : " + "Id: " + customer.Id + " // " + " İsim: " + customer.Ad + " // " + " Soyisim: " + customer.Soyad + " //" + " Yaş: " + customer.Yas);
        }
    }
}
