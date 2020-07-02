using System;

public class Program
{
    static void Nhap(out int[] A)
    {
        Console.WriteLine("Nhap so phan tu: ");
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
            Console.WriteLine(i);
        }
    }
    static void TK(int x, int[] A)
    {
        int c = 0;
        foreach (int i in A)
        {
            if (i == x) c++;
        }
        if (c == 0) Console.WriteLine("Khong co phan tu {0} trong mang", x);
        else Console.WriteLine("Co {0} phan tu {1} trong mang", c, x);
    }
    static void SX(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
            for (int j = i; j < A.Length; j++)
            {
                if (A[j] < A[i])
                {
                    int t = A[i]; A[i] = A[j]; A[j] = t;
                }
            }
        Xuat(A);
    }

    public static void Main()
    {
        int[] A;
        Nhap(out A);
        Xuat(A);
        TK(5, A);
        SX(A);
    }
}