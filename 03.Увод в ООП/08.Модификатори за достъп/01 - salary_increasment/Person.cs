using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary_increasment {
    class Person {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public string FirstName => firstName;
        public string LastName => lastName;
        public int Age => age;
        public double Salary => salary;

        public override string ToString() {
            return $"{firstName} {lastName} gets {salary:f2} leva";
        }

        public Person(string firstName, string lastName, int age, double salary) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public void IncreaseSalary(double bonus){
            if(age > 30){
                salary += salary * bonus / 100;
            }
            else{
                salary += salary * bonus / 200;
            }
        }
    }
}
