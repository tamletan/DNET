using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1CuoiKy
{
    public class ViewClass
    {
        public int Id { get; set; }

        public string NhanVien { get; set; }
        public string DocGia { get; set; }
        public string Sach { get; set; }

        public DateTime Ngaymuon { get; set; }
        public DateTime Ngaytra { get; set; }
        public DateTime Ngayhentra { get; set; }
        public static ViewClass toView(MUONTRA a)
        {
            return new ViewClass()
            {
                Id = a.Id,
                NhanVien = a.NHANVIEN.Hoten,
                DocGia = a.DOCGIA.Hoten,
                Sach = a.SACH.Tensach,
                Ngaymuon = a.Ngaymuon,
                Ngaytra = a.Ngaytra,
                Ngayhentra = a.Ngayhentra
            };
        }
        public static List<ViewClass> toListView(List<MUONTRA> a)
        {
            List<ViewClass> l = new List<ViewClass>();
            foreach(MUONTRA i in a)
            {
                l.Add(toView(i));
            }
            return l;
        }
    }
    
}
