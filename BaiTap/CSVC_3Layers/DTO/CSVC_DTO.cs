using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVC_3Layers
{
    public class CSVC_DTO
    {
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int Tang { get; set; }
        public int MaLoaiPhong { get; set; }
        public bool TrangThai { get; set; }
        public DateTime NgaySuDung { get; set; }
        /*
        public static bool CompareDay(object p1, object p2, bool check)
        {
            if (((CSVC_DTO)p1).NgaySuDung < ((CSVC_DTO)p2).NgaySuDung) return check;
            return !check;
        }
        public static bool CompareName(object p1, object p2, bool check)
        {
            if ((String.Compare(((CSVC_DTO)p1).TenPhong, ((CSVC_DTO)p2).TenPhong)) <= 0) return check;
            return !check;
        }
        public static bool CompareID(object p1, object p2, bool check)
        {
            if (((CSVC_DTO)p1).MaPhong < ((CSVC_DTO)p2).MaPhong) return check;
            return !check;
        }
        public static bool CompareFloor(object p1, object p2, bool check)
        {
            if (((CSVC_DTO)p1).Tang < ((CSVC_DTO)p2).Tang) return check;
            return !check;
        }
        public static bool CompareType(object p1, object p2, bool check)
        {
            if ((String.Compare(((CSVC_DTO)p1).LoaiPhong, ((CSVC_DTO)p2).LoaiPhong)) <= 0) return check;
            return !check;
        }
        public static bool CompareStatus(object p1, object p2, bool check)
        {
            if (((CSVC_DTO)p1).TrangThai && !((CSVC_DTO)p2).TrangThai) return check;
            return !check;
        }
        */
    }
}
