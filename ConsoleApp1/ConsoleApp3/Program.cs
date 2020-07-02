using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Nhap(out int[][] A)
        {
            Console.Write("Nhap kich thuoc mang: ");
            int m = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            A = new int[m][];
            int count = 0, c = m;
            for (int i = 0; i < m; i++)
            {
                A[i] = new int[c];
                for (int j = 0; j < c; j++)
                    //A[i,j] = Convert.ToInt32(Console.ReadLine());
                    A[i][j] = ++count;
                c--;
            }
        }
        static void Xuat(int[][] A)
        {
            /*for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A[i].GetLength(0); j++)
                    Console.Write(A[i][j] + "  ");*/
            foreach (int[] arr in A)
            {
                foreach (int i in arr)
                    Console.Write(i + "  ");
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int[][] A;
            Nhap(out A);
            Xuat(A);
            Console.ReadKey();
        }
    }
}
