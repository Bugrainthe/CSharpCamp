using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {


            int age = 17;

            switch (age)
            {
                case 3:
                    Console.WriteLine("Bebek");
                    break;
                case 10:
                    Console.WriteLine("Çocuk");
                    break;
                case 18:
                    Console.WriteLine("Genç");
                    break;
                case 40:
                    Console.WriteLine("Yetkişkin");
                    break;
                default:
                    Console.WriteLine(age + " Yaşında");
                    break;
            }

            bool flex = true;

            while (flex)
            {
                if (flex == true)
                {
                    Console.WriteLine("flex is true!");
                    break;
                }
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
    class MyClass
    {

    }
}
