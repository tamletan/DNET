using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLISACH
{
    public class bll
    {
        public Model1 db { get; set; }
        public bll()
        {
            db = new Model1();
        }

        public List<ClassView> show_bll()
        {
            return ClassView.cast_to_list(db.MuonTras.ToList());
        }

        public void AddData(MuonTra s)
        {
            db.MuonTras.Add(s);
            db.SaveChanges();
        }

        internal object loadListComboSach()
        {
            return db.Sachs.Select(p => new { p.TenSach, p.MaSach }).ToList();
        }

        internal object loadListComboDOcGia()
        {
            return db.DocGias.Select(p1 => new { p1.MaDG, p1.HoTenDG }).ToList();
        }

        internal object loadListComboNhanVien()
        {
            return db.NhanViens.Select(p2 => new { p2.MaNV, p2.HoTenNV }).ToList();
        }
    }
}
