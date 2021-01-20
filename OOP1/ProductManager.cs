using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        public void Add(Product product)
        {
            Console.WriteLine("Başaryıla eklendi. : ");
        }
        public int Sum(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Sum2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
