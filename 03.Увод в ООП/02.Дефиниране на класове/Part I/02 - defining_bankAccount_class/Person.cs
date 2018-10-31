using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_bankAccount_class {
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
        public List<BankAccount> Accounts {
            get {
                return bankAccounts;
            }
            set {
                bankAccounts = value;
            }
        }
        public double GetBalance(){
            double money = 0;
            for (int i = 0; i < bankAccounts.Count; i++){
                money += bankAccounts[i].Balance;
            }
            return money;
        }
    }
}
