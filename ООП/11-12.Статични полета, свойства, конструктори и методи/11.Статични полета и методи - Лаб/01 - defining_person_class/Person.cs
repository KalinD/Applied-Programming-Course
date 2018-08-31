using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_person_class {
    class Person {
        private static int count;
        private int age;
        private string name;

        public Person() {
            count++;
        }

        public static int Count => count;

        public int Age{
            get => age;
            set => age = value;
        }

        public string Name{
            get => name;
            set => name = value;
        }
    }
}
