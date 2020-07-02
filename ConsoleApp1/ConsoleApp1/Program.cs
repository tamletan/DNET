using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Nhap(out int[] A)
        {
            Console.Write("Nhap so phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Xuat(int[] A)
        {
            foreach (int i in A)
            {
                Console.Write(i+"  ");
            }
        }
        static void SwapMax(int[] A)
        {
            int index = 0,m = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > m)
                {
                    m = A[i];
                    index = i;
                }
            }
            int t = A[index];
            A[index] = A[A.Length / 2];
            A[A.Length / 2] = t;
        }
        static void Main()
        {
            int[] A;
            Nhap(out A);
            SwapMax(A);
            Array.Sort(A, 0, A.Length / 2);
            Array.Sort(A, A.Length / 2, A.Length - A.Length / 2);
            Array.Reverse(A, A.Length / 2, A.Length - A.Length / 2);
            Xuat(A);
            Console.ReadKey();

        }
    }
}
