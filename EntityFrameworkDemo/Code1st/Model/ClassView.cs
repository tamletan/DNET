using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1st
{
    public class ClassView
    {
        public int ID { get; set; }
        public string TenSV { get; set; }
        public string Gioitinh { get; set; }
        public double Diem { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string TenKhoa { get; set; }
        public static ClassView Cast(SinhVien A)
        {
            ClassView temp = new ClassView
            {
                ID = A.ID,
                TenSV = A.TenSV,
                Gioitinh = (A.Gioitinh == true) ? "Nam":"Nu",
                Diem = A.Diem,
                Ngaysinh = A.Ngaysinh,
                TenKhoa = A.Khoa.TenKhoa
            };
            return temp;
        }
        public static List<ClassView> CastToList(List<SinhVien> A)
        {
            List<ClassView> temp = new List<ClassView>();
            foreach (SinhVien i in A)
                temp.Add(Cast(i));
            return temp;
        }
    }
}
