using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt
{
    class SV
    {
        string MSSV;
        int Age;
        bool Gender;
        public SV(string MSSV="", int Age=0, bool Gender=false)
        {
            this.MSSV = MSSV;
            this.Age = Age;
            this.Gender = Gender;
        }
        public string Maso
        {
            get
            {
                return MSSV;
            }
            set
            {
                if (value.Length == 9)
                    MSSV = value;
            }
        }
        public int Tuoi
        {
            get
            {
                return Age;
            }
            set
            {
                if (16<=value && value<=30)
                    Age = value;
            }
        }
        public bool Gioitinh
        {
            get
            {
                return Gender;
            }
            set
            {
                if (value==true||value==false)
                    Gender = value;
            }
        }
        public void Xuat()
        {
            Console.Write("MSSV: {0}    Age: {1}    Gender: ",MSSV,Age);
            if(Gender==true) Console.WriteLine("Male");
            else Console.WriteLine("Female");
        }
        public void Nhap()
        {
            Console.Write("Nhap ma so sinh vien: ");
            this.Maso = Console.ReadLine();
            Console.Write("Nhap tuoi sinh vien: ");
            this.Tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gioi tinh sinh vien (Male=1 | Female=0): ");
            this.Gioitinh = Convert.ToBoolean(Console.ReadLine());
        }
    }
}
