using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace defining_person_class_bonus {
    class Program {
        static void Main(string[] args) {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
            Person p1 = new Person();
            p1.name = "Pesho";
            p1.age = 20;
            Person p2 = new Person();
            p2.name = "Gosho";
            p2.age = 18;
            Person p3 = new Person();
            p3.name = "Stamat";
            p3.age = 43;

        }
    }
}
