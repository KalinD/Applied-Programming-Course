using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_person_class {
    class Program {
        static void Main(string[] args) {
            Person firstPerson = new Person();
            firstPerson.Name = "Gosho";
            firstPerson.Age = 15;
            firstPerson.IntroduceYourself();
        }
    }
}
