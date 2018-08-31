using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_and_reserve_team {
    class Person {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public string FirstName{
            get => firstName;
            set{
                if(value.Length < 3){
                    throw new ArgumentException("First name must be atleast 3 characters");
                }
                firstName = value;
            }
        }

        public string LastName {
            get => lastName;
            set {
                if (value.Length < 3) {
                    throw new ArgumentException("Last name must be atleast 3 characters");
                }
                lastName = value;
            }
        }

        public double Salary{
            get => salary;
            set{
                if(value < 460){
                    throw new ArgumentException("Salary must be atleast 460 leva");
                }
                salary = value;
            }
        }

        public int Age{
            get => age;
            set{
                if(value < 1){
                    throw new ArgumentException("Age must be positive integet");
                }
                age = value;
            }
        }

        public Person(string fName, string lName, int age, double salary){
            FirstName = fName;
            LastName = lName;
            Age = age;
            Salary = salary;
        }
    }
}
