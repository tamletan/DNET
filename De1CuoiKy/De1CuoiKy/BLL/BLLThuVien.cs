using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1CuoiKy
{

    public class BLLThuVien
    {
        public De1DB db { get; set; }

        public BLLThuVien()
        {
            db = new De1DB();
        }

        public List<ViewClass> GetListMuonTra_BLL()
        {
            return ViewClass.toListView(db.MuonTras.ToList());
        }

        public object GetListSach_BLL()
        {
            return db.Sachs.Select(p => new
            {
                p.Masach,
                p.Tensach,
                p.LOAISACH.TenLoai,
                p.Sotrang,
                p.Tacgia,
                p.NXB
            }).ToList();
        }

        public object GetListNhanVien_BLL()
        {
            return db.NhanViens.Select(p => new
            {
                p.Manv,
                p.Hoten,
                Gioitinh = p.Gioitinh == true ? "Nam" : "Nu",
                SoLuongMT = p.MUONTRAs.Count
            }).ToList();
        }

        public  object getComboDocgia_BLL()
        {
            return db.DocGias.Select(p => new
            {
                Ten = p.Hoten,
                p.Madg
            }).ToList();
        }

        public object getComboNhanVien_BLL()
        {
            return db.NhanViens.Select(p => new
            {
                Ten = p.Hoten,
                p.Manv
            }).ToList();
        }

        public object getComboSach_BLL()
        {
            return db.Sachs.Select(p => new
            {
                Ten = p.Tensach,
                p.Masach
            }).ToList();
        }

        public object GetListDocGia_BLL()
        {
            return db.DocGias.Select(p => new
            {
                p.Madg,
                p.Hoten,
                Gioitinh = p.Gioitinh==true? "Nam":"Nu",
                p.Ngaysinh,
                p.Diachi,
                p.Coquan,
                SoSachDaMuon = p.MUONTRAs.Count
            }).ToList();
        }

        public void AddMuonTra_BLL(MUONTRA a)
        {
            db.MuonTras.Add(a);
            db.SaveChanges();
        }
    }
}
