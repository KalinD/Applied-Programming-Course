using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_check {
    class Person {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public string FirstName{
            get => firstName;
            set{
                if(value.Length < 3){
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }
                firstName = value;
            }
        }
        public string LastName{
            get => lastName;
            set{
                if (value.Length < 3) {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }
                lastName = value;
            }
        }
        public int Age{
            get => age;
            set{
                if (value < 1) {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                age = value;
            }
        }
        public double Salary{
            get => salary;
            set {
                if (value < 460) {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
                salary = value;
            }
        }
        public override string ToString() {
            return $"{firstName} {lastName} gets {salary:f2} leva";
        }

        public Person(string firstName, string lastName, int age, double salary) {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(double bonus) {
            if (age > 30) {
                salary += salary * bonus / 100;
            }
            else {
                salary += salary * bonus / 200;
            }
        }
    }
}
