using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_people_by_name_and_age {
    class Person {
        private string firstName;
    	private string lastName;
        private int age;

        public string FirstName => firstName;
        public string LastName => lastName;
        public int Age => age;

        public override string ToString() {
            return $"{firstName} {lastName} is a {age} years old";
        }

        public Person(string firstName, string lastName, int age){
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }
}
