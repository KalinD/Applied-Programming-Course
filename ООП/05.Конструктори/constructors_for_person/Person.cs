using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors_for_person {
    class Person {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public Person() {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age) {
            this.name = "No name";
            this.age = age;
        }

        public Person(string name, int age) : this(name, age, new List<BankAccount>()){
        }

        public Person(string name, int age, List<BankAccount> accounts){
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public int Age{
            get{
                return age;
            }
            set{
                age = value;
            }
        }

        public List<BankAccount> Accounts{
            get{
                return accounts;
            }
            set{
                accounts = value;
            }
        }
        public double Balance(){
            return accounts.Sum(x => x.Amount);
        }
    }
}
