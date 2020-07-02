using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt
{
    class ListSV
    {
        SV[] data;
        static int siso = 0;
        public ListSV(int n)
        {
            data = new SV[n];
        }
        public void Add(SV s)
        {
            for (int i=0;i<data.Length;i++)
            {
                if (data[i] == null)
                {
                    data[i] = s;
                    siso++;
                    break;
                }
            }
        }
        public void Edit(SV s)
        {
            if (s != null)
            {
                for (int i = 0; i < siso; i++)
                {
                    if (data[i].Maso == s.Maso && data[i].Tuoi == s.Tuoi && data[i].Gioitinh == s.Gioitinh)
                    {
                        Console.Write("Nhap lai ma so sinh vien: ");
                        data[i].Maso = Console.ReadLine();
                        Console.Write("Nhap lai tuoi sinh vien: ");
                        data[i].Tuoi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap lai gioi tinh sinh vien (Male=1 | Female=0): ");
                        int t = Convert.ToInt32(Console.ReadLine());
                        if (t == 1) data[i].Gioitinh = true;
                        else data[i].Gioitinh = false;
                    }
                }
            }
        }
        public void Show()
        {
            //for (int i = 0; i < siso; i++)
            //    data[i].Xuat();
            foreach (SV i in data)
                if(i!= null) i.Xuat();
        }
        public void Delete(SV s)
        {
            for (int i=0;i<siso;i++)
            {
                if (data[i].Maso == s.Maso && data[i].Tuoi == s.Tuoi && data[i].Gioitinh == s.Gioitinh)
                {
                    for (int j = i+1; j < siso; j++)
                        data[j-1] = data[j];
                    data[siso - 1] = null;
                    siso--;
                }
            }
        }
        public SV Find(string Maso)
        {
            foreach (SV s in data)
            {
                if (s != null && s.Maso == Maso) return s;
            }
            return null;
        }
    }
}
