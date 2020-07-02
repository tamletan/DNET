using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Student
    {
        public int MSSV { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Faculty { get; set; }
        public double DTB { get; set; }
        public bool Gender { get; set; }
        public static bool CompareName(object p1, object p2)
        {
            if ((String.Compare(((Student)p1).Name, ((Student)p2).Name)) <= 0) return true;
            return false;
        }
        public static bool CompareKHOA(object p1, object p2)
        {
            if ((String.Compare(((Student)p1).Faculty, ((Student)p2).Faculty)) <= 0) return true;
            return false;
        }
        public static bool CompareId(object p1, object p2)
        {
            if (((Student)p1).MSSV < ((Student)p2).MSSV) return true;
            return false;
        }
        public static bool ComparePoint(object p1, object p2)
        {
            if (((Student)p1).DTB < ((Student)p2).DTB) return true;
            return false;
        }
        public static bool CompareGender(object p1, object p2)
        {
            if (((Student)p1).Gender && !((Student)p2).Gender) return true;
            return false;
        }
        public static bool CompareBirth(object p1, object p2)
        {
            if (((Student)p1).Birth < ((Student)p2).Birth) return true;
            return false;
        }
    }
}
