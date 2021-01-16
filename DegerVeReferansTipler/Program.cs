using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,double,bool değer tip
            //arrays,class,interfaces referans tip (referans tipler 101 gibi 102 gibi) 101 101 in karşına geçer 102 102 nin karşısına geçer ama 101 i 102 ye bağlarsan 101 çöp olarak kabul edeilir.
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //Değere atarsın
            Console.WriteLine(sayi1); //30 döndürücek

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2; //Referans kodunu atarsın 
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]); //999 Döndürücek

            Console.ReadLine();
        }
    }
}
