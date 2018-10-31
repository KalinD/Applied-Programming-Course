using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace defining_person_class{
    class Program{
        static void Main(string[] args){
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
            Person p1 = new Person("Pesho", 20);
            Person p2 = new Person("Gosho", 18);
            Person p3 = new Person("Stamat", 43);
        }
    }
}
