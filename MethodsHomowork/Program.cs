using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomowork
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int number1 = 50;
            int number2 = 60;

            var result1 = MathSum1(2,5);//2 Parametreli Metot.

            var result2 = MathSum2(ref number1, number2);//Ref keywordunu kullandığınız parametrenin ana metot içinde değer almasına gerek vardır.

            var result3 = MathSum3(number1 , out number);//Out keywordunu kullandığınız parametrenin ana metot içinde değer almasına gerek yoktur.

            Console.WriteLine(result3);

            Console.ReadLine();
        }

        static int MathSum1(int number1, int number2)
        {
            //Normal metot
            return number1 + number2;
        }

        static int MathSum2(ref int number1, int number2)//Her ikisininde başına ref koyabilirsiniz.
        {
            //Ref keywordunde number1 i bu methot içinde set etmenize gerek yoktur.
            return number1 + number2;
        }

        static int MathSum3(int number1,out int number2)//Her ikisininde başına out koyabilirsiniz.
        {
            //out keywordu ile çalışırsanız bu methot'un içine hangi değişkene atadıysanız out keywordunu o değişkeni bu method içinde set etmeniz gerekmektedir.
            number2 = 5;
            return number1 + number2;
        }
    }
}
