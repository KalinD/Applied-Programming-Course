using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_person_class {
    class Person {
        private string name;
        private int age;

        public String Name{
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public int Age {
            get {
                return age;
            }
            set {
                age = value;
            }
        }
        
        public void IntroduceYourself(){
            Console.WriteLine($"Hello, I am {name} {age} years old.");
        }
    }
}
