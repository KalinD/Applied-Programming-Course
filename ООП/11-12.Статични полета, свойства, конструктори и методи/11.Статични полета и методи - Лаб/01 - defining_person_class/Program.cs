using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_person_class {
    class Program {
        static void Main(string[] args) {
            Person person1 = new Person();
            Console.WriteLine(Person.Count);
            Person person2 = new Person();
            Console.WriteLine(Person.Count);
        }
    }
}
