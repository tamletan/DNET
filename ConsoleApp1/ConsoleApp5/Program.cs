using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public delegate void MyDelg(int x, int y);
    class Program
    {
        static void Sum(int a, int b) { Console.WriteLine("Sum = {0}", a + b); }
        static void Sub(int a, int b) { Console.WriteLine("Sub = {0}", a - b); }
        static void Cal(int a, int b, MyDelg x) { x(a, b); }
        static void Main(string[] args)
        {
            MyDelg d = new MyDelg(Sum);
            //int c = d(5, 6), z = d.Invoke(5, 6);
            //Console.WriteLine("c = " + c + ", z = " + z);
            //int y = Cal(2, 4, d), x = Cal(2, 4, Sum);
            //Console.WriteLine("y = " + y + ", x = " + x);
            d += new MyDelg(Sub); d += new MyDelg(Sub);
            d -= new MyDelg(Sub);
            d(5, 7);
            Cal(5, 7, d);
            Console.ReadLine();
        }
    }
}
