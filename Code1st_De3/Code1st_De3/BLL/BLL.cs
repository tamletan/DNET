using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1st_De2
{
    public class BLL
    {
        public De2Code1st db;
        public BLL()
        {
            db = new De2Code1st();
        }
        public List<MuonTra> show()
        {
            return db.MuonTras.ToList();
        }
        public List<DocGia> showDocGia()
        {
            return db.DocGias.ToList();
        }
        public List<Sach> showSach()
        {
            return db.Sachs.ToList();
        }
        public List<NhanVien> showNhanVien()
        {
            return db.NhanViens.ToList();
        }
        public void Add(MuonTra A)
        {
            db.MuonTras.Add(A);
            db.SaveChanges();
        }
        public void Add(DocGia A)
        {
            db.DocGias.Add(A);
            db.SaveChanges();
        }
        public void Add(NhanVien A)
        {
            db.NhanViens.Add(A);
            db.SaveChanges();
        }
        public void Add(Sach A)
        {
            db.Sachs.Add(A);
            db.SaveChanges();
        }
        public void Update(Sach A,int ID)
        {
            var k = db.Sachs.Where(p => p.ID == ID).FirstOrDefault();
            k.TenSach = A.TenSach;
            k.TacGia = A.TacGia;
            k.NXB = A.NXB;
            k.IDS = A.IDS;
            k.SoLuong = A.SoLuong;
            k.SoTrang = A.SoTrang;
            db.SaveChanges();
        }
        public void Update(MuonTra A, int ID) { }
        public void Update(DocGia A, int ID) { }
        public void Update(NhanVien A, int ID) { }
        public Sach load1S(int ID)
        {
            return db.Sachs.Where(p => p.ID == ID).FirstOrDefault();
        }
        public List<LoaiSach> loadLS()
        {
            return db.LoaiSachs.ToList();
        }
    }
}
