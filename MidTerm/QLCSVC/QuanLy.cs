using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSVC
{
    public class QuanLy
    {
        public List<CSVC> list;
        public QuanLy()
        {
            list = new List<CSVC>();
        }
        public void Del(List<int> maP)
        {
            int n = list.Count;
            for (int i = n - 1; i >= 0; i--)
                if (maP.Contains(list[i].MaPhong))
                    list.RemoveAt(i);
        }
        public delegate bool Comp(object x, object y, bool check);
        public static void MySort(List<CSVC> A, Comp cmp, bool check)
        {
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i + 1; j < A.Count; j++)
                {
                    if (cmp(A[j], A[i], check))
                    {
                        CSVC t = A[i];
                        A[i] = A[j];
                        A[j] = t;
                    }
                }
            }
        }
        public List<CSVC> Sort(string s, List<CSVC> L, bool check)
        {
            List<CSVC> listsort = new List<CSVC>(L);
            switch (s)
            {
                case "MaPhong":
                    MySort(listsort, CSVC.CompareID, check);
                    break;
                case "TenPhong":
                    MySort(listsort, CSVC.CompareName, check);
                    break;
                case "Tang":
                    MySort(listsort, CSVC.CompareFloor, check);
                    break;
                case "LoaiPhong":
                    MySort(listsort, CSVC.CompareType, check);
                    break;
                case "TrangThai":
                    MySort(listsort, CSVC.CompareStatus, check);
                    break;
                case "NgaySuDung":
                    MySort(listsort, CSVC.CompareDay, check);
                    break;
                default:
                    break;
            }
            return listsort;
        }
        public List<CSVC> Search(string s, List<CSVC> L)
        {
            List<CSVC> result = new List<CSVC>();
            s = s.ToUpper();
            foreach (CSVC i in L)
            {
                if (i.TenPhong.ToString().ToUpper().Contains(s) || i.MaPhong.ToString().ToUpper().Contains(s))
                    result.Add(i);
            }
            return result;
        }
    }
}
