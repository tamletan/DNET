using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public delegate bool Comp(object x, object y);
    public class QLSV
    {        
        public List<Student> List { get; set; }
        public QLSV()
        {
            List = new List<Student>();
        }
        public void Show() {
                          
        }
        public void Del(List<int> mssv) {
            int n = List.Count;
            for (int i=n-1;i>=0;i--)            
                if (mssv.Contains(List[i].MSSV))
                    List.RemoveAt(i);
        }
        public void Update(Student sv) { }
        public void Add(Student sv) { }
        public List<Student> Search(string s, List<Student> L) {
            List<Student> result = new List<Student>();
            s = s.ToUpper();
            bool g=false;
            if (s == "MALE") g = true;
            if (s == "FEMALE") g = false;
            foreach (Student i in L)
            {
                if (i.MSSV.ToString().ToUpper().Contains(s) || i.Name.ToUpper().Contains(s) || i.Faculty.ToUpper().Contains(s) || i.DTB.ToString().ToUpper().Contains(s) || g==i.Gender)
                    result.Add(i);
            }
            return result;
        }
        public List<Student> Sort(string s, List<Student> L) {
            List<Student> listsort = new List<Student>(L);
            switch (s)
            {
                case "MSSV":
                    MySort(listsort, Student.CompareId);
                    break;
                case "Name":
                    MySort(listsort, Student.CompareName);
                    break;
                case "Birth":
                    MySort(listsort, Student.CompareBirth);
                    break;
                case "Faculty":
                    MySort(listsort, Student.CompareKHOA);
                    break;
                case "Gender":
                    MySort(listsort, Student.CompareGender);
                    break;
                case "DTB":
                    MySort(listsort, Student.ComparePoint);
                    break;
            }
            return listsort;
        }
        public static void MySort(List<Student> A, Comp cmp)
        {
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i + 1; j < A.Count; j++)
                {
                    if (cmp(A[j], A[i]))
                    {
                        Student t = A[i];
                        A[i] = A[j];
                        A[j] = t;
                    }
                }
            }
        }
    }
}
