using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public delegate bool Comp(object x, object y);
    class Program
    {
        public static void MySort(List<object> A, Comp cmp)
        {
            for(int i=0;i<A.Count;i++)
            {
                for(int j=i+1;j<A.Count; j++)
                {
                    if (cmp(A[j], A[i]))
                    {
                        object t = A[i];
                        A[i] = A[j];
                        A[j] = t;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<Person> p = new List<Person>(3);
            p.Add(new Person("Hung", 21));
            p.Add(new Person("Tran", 27));
            p.Add(new Person("Duy", 24));
            List<object> obj = Person.Tolist(p);
            MySort(obj, Person.CompareAge);
            Console.WriteLine("So sanh tuoi:");
            foreach (Person i in obj)
                i.Show();
            MySort(obj, Person.CompareName);
            Console.WriteLine("\nSo sanh ten:");
            foreach (Person i in obj)
                i.Show();
            Console.ReadKey();            
        }
    }
}
