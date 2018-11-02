using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_metodes_to_bank_account_class {
    class BankAccount {
        private int id;
        private double balance;
        public int ID{
            get{
                return id;
            }
            set{
                id = value;
            }
        }
        public double Balance {
            get {
                return balance;
            }
            set {
                balance = value;
            }
        }
        public void Deposit(double amount){
            balance += amount;
        }
        public void Withdraw(double amount){
            if(balance - amount < 0){
                Console.WriteLine("Insufficient balance");
                return;
            }
            balance -= amount;
        }
        public override string ToString() {
            return $"Account ID{this.id}, balance {this.balance:f2}";
        }
    }
}

