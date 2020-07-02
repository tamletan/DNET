using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLISACH
{
    public class ClassView
    {
        public int ID { get; set; }
        public string DocGia { get; set; }
        public string NhanVien { get; set; }
        public string TenSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }

        public static ClassView View(MuonTra s)
        {
            return new ClassView()
            {
                ID = s.ID,
                NhanVien = s.NhanVien.HoTenNV,
                DocGia = s.DocGia.HoTenDG,
                TenSach = s.Sach.TenSach,
                NgayMuon = s.NgayMuon,
                NgayTra = s.NgayTra,
            };
        }

        public static List<ClassView> cast_to_list(List<MuonTra> list)
        {
            List<ClassView> listout = new List<ClassView>();
            foreach (MuonTra i in list)
            {
                listout.Add(View(i));
            }
            return listout;
        }
    }
}
