using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.BLL
{
    public class GVBLL
    {
        public Models.QLGVContext db;
        List<Models.GVView> listview;

        public GVBLL()
        {
            db = new Models.QLGVContext();
            listview = new List<Models.GVView>();
        }

        public Models.GV GetGVSTT(int z)
        {
            Models.GVView obj = listview.Where(p => p.STT == z).FirstOrDefault();
            Models.GV result = db.GVs.Where(p => p.Id == obj.ID).FirstOrDefault();
            return result;
        }

        public Models.GV GetGV(int z)
        {
            Models.GV obj = db.GVs.Where(p => p.Id == z).FirstOrDefault();
            return obj;
        }

        public List<Models.CoSo> GetCSs()
        {
            return db.CoSos.ToList();
        }

        public int GetCSs(int iddv)
        {
            return db.DVDTs.Where(p => p.Id == iddv).FirstOrDefault().MaCoSo;
        }

        public List<Models.DVDT> GetDVDTs()
        {
            return db.DVDTs.ToList();
        }

        public List<Models.DVDT> GetDVDTs(int idcs)
        {
            return db.DVDTs.Where(p => p.MaCoSo == idcs).ToList();
        }

        public void AddGV(Models.GV s, int z)
        {
            Models.DVDT dt = db.DVDTs.Where(p => p.Id == z).FirstOrDefault();
            dt.GVs.Add(s);
            db.SaveChanges();
        }

        public void EditGV(Models.GV s, int z)
        {
            Models.GV gv = db.GVs.Where(p => p.Id == s.Id).FirstOrDefault();
            gv.HoTen = s.HoTen;
            gv.GioiTinh = s.GioiTinh;
            gv.GhiChu = s.GhiChu;
            gv.NgaySinh = s.NgaySinh;
            gv.SDT = s.SDT;
            if (gv.MaDVDT != z)
            {
                Models.DVDT oldlh = db.DVDTs.Where(p => p.Id == s.MaDVDT).FirstOrDefault();
                oldlh.GVs.Remove(gv);
                Models.DVDT newlh = db.DVDTs.Where(p => p.Id == z).FirstOrDefault();
                newlh.GVs.Add(gv);
            }
            db.SaveChanges();
        }

        public void RemoveGV(List<int> list)
        {
            foreach (int i in list)
            {
                Models.GV gv = db.GVs.Where(p => p.Id == i).FirstOrDefault();
                Models.DVDT dv = db.DVDTs.Where(p => p.Id == gv.MaDVDT).FirstOrDefault();
                db.GVs.Remove(gv);
                dv.GVs.Remove(gv);
            }
            db.SaveChanges();
        }

        public List<Models.GVView> ShowGV(int iddv)
        {
            List<Models.GV> list = db.GVs.Where(p => p.MaDVDT == iddv).ToList();
            listview.Clear();
            int stt = 0;
            foreach (Models.GV c in list)
            {
                stt++;
                Models.GVView r = new Models.GVView()
                {
                    STT = stt,
                    ID = c.Id,
                    HoTen = c.HoTen,
                    SDT = c.SDT,
                    GhiChu = c.GhiChu
                };
                listview.Add(r);
            }
            return listview;
        }

        public List<Models.GVView> ShowGV(List<Models.GV> list)
        {
            listview.Clear();
            int stt = 0;
            foreach (Models.GV c in list)
            {
                stt++;
                Models.GVView r = new Models.GVView()
                {
                    STT = stt,
                    ID = c.Id,
                    HoTen = c.HoTen,
                    SDT = c.SDT,
                    GhiChu = c.GhiChu
                };
                listview.Add(r);
            }
            return listview;
        }

        public List<Models.GVView> SearchGV(string find, List<int> idgv)
        {
            List<Models.GV> list = db.GVs.Where(p => idgv.Contains(p.Id) && p.HoTen.Contains(find)).ToList();            
            return ShowGV(list);
        }
        
        public List<Models.GVView> SortGV(string field, List<int> idgv)
        {
            List<Models.GV> list = db.GVs.Where(p => idgv.Contains(p.Id)).ToList();
            listview.Clear();
            listview = ShowGV(list);
            switch (field)
            {
                case "Họ tên Giảng viên":
                    MySort(listview, CompName);
                    break;
                case "Phone":
                    MySort(listview, CompPhone);
                    break;
                case "Ghi Chú":
                    MySort(listview, CompGC);
                    break;
                default:
                    break;
            }
            return listview;
        }
        
        public delegate bool Comp(object x, object y);
        public bool CompName(object p1, object p2)
        {
            if (String.Compare(((Models.GVView)p1).HoTen, ((Models.GVView)p2).HoTen) < 0) return true;
            return false;
        }
        public bool CompPhone(object p1, object p2)
        {
            if ( ((Models.GVView)p1).SDT < ((Models.GVView)p2).SDT ) return true;
            return false;
        }
        public bool CompGC(object p1, object p2)
        {
            if (String.Compare(((Models.GVView)p1).GhiChu, ((Models.GVView)p2).GhiChu) < 0) return true;
            return false;
        }
        public void MySort(List<Models.GVView> A, Comp cmp)
        {
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i + 1; j < A.Count; j++)
                {
                    if (cmp(A[j], A[i]))
                    {
                        int stt1 = A[i].STT;
                        int stt2 = A[j].STT;
                        Models.GVView t = A[i];
                        A[i] = A[j];
                        A[j] = t;
                        A[i].STT = stt1;
                        A[j].STT = stt2;
                    }
                }
            }
        }
    }
}
