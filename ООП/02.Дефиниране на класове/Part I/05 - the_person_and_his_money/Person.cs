using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_person_and_his_money {
    class Person {
        private int age;
        private string name;
        private List<BankAccount> bankAccounts = new List<BankAccount>();
        public int Age{
            get{
                return age;
            }
            set{
                age = value;
            }
        }
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public List<BankAccount> Accounts{
            get{
                return bankAccounts;
            }
            set{
                bankAccounts = value;
            }
        }
        public double GetBalance(){
            return this.bankAccounts.Sum(x => x.Balance);
        }
    }
}
