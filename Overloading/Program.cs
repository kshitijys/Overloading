using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Program
    {
            static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {

            int a = 10, b = 20;
            Swap(ref a, ref b);
            Console.WriteLine($"a= {a} b={b}");



            //Addition a1=new Addition();
            //Console.WriteLine(a1.add (1,2));
            //Console.WriteLine(a1.add(5,6,7));
            //Console.WriteLine(a1.add(10.5,8));
            //Console.WriteLine(a1.add(9.50f,9.6));


            //_________________________________________

            //Circle c1=new Circle(9);
            //c1.calculatearea();
            //Console.WriteLine(c1);


            //_________________________________________

            //Rectangle r1 = new Rectangle(5, 4);
            //r1.calculatearea();
            //Console.WriteLine(r1);

        }
    }
}
