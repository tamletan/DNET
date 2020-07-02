using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1st
{
    public class BLL
    {
        SinhVienCode1st db;
        public BLL()
        {
            db = new SinhVienCode1st();
        }
        public SinhVien LoadStudent(int IDSV)
        {
            var sv = db.SinhViens.Where(p => p.ID == IDSV).FirstOrDefault();
            return sv;
        }
        public List<Khoa> loadfalce()
        {
            var k = db.Khoas.Select(p => p).ToList();
            return k;
        }
        public List<ClassView> GetClassView()
        {
            return ClassView.CastToList(db.SinhViens.ToList());
        }
        public void Delete(int IDSV)
        {
            var sv = db.SinhViens.Where(p => p.ID == IDSV).FirstOrDefault();
            db.SinhViens.Remove(sv);
            db.SaveChanges();
        }
        public void Add(SinhVien A)
        {
            db.SinhViens.Add(A);
            db.SaveChanges();
        }
        public List<ClassView> Search(string key)
        {
            List<ClassView> search = new List<ClassView>();
            foreach(ClassView i in GetClassView())
            {
                if (i.ID.ToString().Contains(key) || i.TenSV.Contains(key) || i.Diem.ToString().Contains(key))
                    search.Add(i);
            }
            return search;
        }
        public List<ClassView> SearchWithFalculty(string falc)
        {
            List<ClassView> search = new List<ClassView>();
            foreach (ClassView i in GetClassView())
            {
                if (i.TenKhoa.Contains(falc))
                    search.Add(i);
            }
            return search;
        }
        public List<ClassView> SearchWithGender(string gender)
        {
            List<ClassView> search = new List<ClassView>();
            foreach(ClassView i in GetClassView())
            {
                if (i.Gioitinh.Contains(gender))
                    search.Add(i);
            }
            return search;
        }
        public void Update(SinhVien A,int IDSV)
        {
            var sv = db.SinhViens.Where(p => p.ID == IDSV).FirstOrDefault();
            sv.TenSV = A.TenSV;
            sv.FID = A.FID;
            sv.Gioitinh = A.Gioitinh;
            sv.Ngaysinh = A.Ngaysinh;
            sv.Diem = A.Diem;
            db.SaveChanges();
        }
        public List<Khoa> ForCBBox()
        {
            return db.Khoas.ToList(); ;
        }
    }
}
