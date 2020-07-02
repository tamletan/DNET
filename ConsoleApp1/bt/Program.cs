using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap so SV: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ListSV A = new ListSV(n);
            A.Add(new SV("123", 20, true));
            A.Add(new SV("453", 23, true));
            A.Add(new SV("232", 21, true));
            A.Add(new SV("333", 25, false));
            SV d = new SV("123", 20, true);
            A.Delete(d);
            Console.Write("Nhap MSSV can tim: ");
            string str = Console.ReadLine();
            A.Edit(A.Find(str));
            A.Show();
            Console.ReadKey();
        }
    }
}
