using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carNames = new string[] { "Bmw", "Mercedes", "Opel" };
            Console.WriteLine(carNames[0]);
            Console.WriteLine(carNames[1]);
            Console.WriteLine(carNames[2]);
            Console.WriteLine(carNames[3]);

            carNames = new string[5];
            carNames[4] = "Wolksvagen";
            Console.WriteLine(carNames[4]);
            Console.WriteLine(carNames[0]);

            List<string> names = new List<string> {"Buğrahan","Emir","Batuhan"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            names.Add("Selçuk");
            Console.WriteLine(names[3]);
            Console.WriteLine(names[0]);

            Console.ReadLine();
        }
    }
}
