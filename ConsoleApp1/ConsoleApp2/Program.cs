using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Nhap(out int[,] A)
        {
            Console.Write("Nhap kich thuoc mang: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            A = new int[m,n];
            int count = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    //A[i,j] = Convert.ToInt32(Console.ReadLine());
                    A[i, j] = ++count;
        }
        static void Xuat(int[,] A)
        {
            foreach (int i in A)
            {
                Console.Write(i + "  ");
            }
        }
        static void Main()
        {
            int[,] A;
            Nhap(out A);
            Xuat(A);
            Console.ReadKey();
        }
    }
}
