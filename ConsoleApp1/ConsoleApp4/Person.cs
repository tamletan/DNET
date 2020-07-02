using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Person
    {
        public string Name
        {
            get;set;
        }
        public int Age
        {
            get;set;
        }
        public Person(string Name = "", int Age = 0)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void Show()
        {
            Console.WriteLine(Name + "  " + Age + " tuoi");
        }
        public static bool CompareAge(object p1,object p2)
        {
            if ( ((Person)p1).Age > ((Person)p2).Age ) return true;
            return false;
        }
        public static bool CompareName(object p1, object p2)
        {
            if ( ((Person)p1).Name.Length < ((Person)p2).Name.Length ) return true;
            return false;
        }
        public static List<object> Tolist(List<Person> p)
        {
            List<object> obj = new List<object>(p.Count);
            foreach(Person i in p)
                obj.Add(i);
            return obj;
        }
    }
}
