using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Telefon";
            product1.Price = 5000;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Bilgisayar";
            product2.Price = 10000;

            Product[] product = new Product[] { product1, product2 };

            foreach (var products in product)
            {
                Console.WriteLine(products.Id);
                Console.WriteLine(products.Name);
                Console.WriteLine(products.Price);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("----------------Methods----------------");
            //Instance - Örnek
            //Encapsulation - Bir şeyi düzenli bir şekilde yazma/kapsülleme olayı

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Bisiklet", "Mavi bisiklet", 500);
            sepetManager.Add2("Tost Makinası", "tost makinası", 300);

            Console.ReadLine();
            int number1;
        }
    }
}
