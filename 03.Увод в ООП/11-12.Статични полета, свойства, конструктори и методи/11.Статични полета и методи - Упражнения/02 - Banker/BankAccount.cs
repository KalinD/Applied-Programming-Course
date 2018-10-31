using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker {
    class BankAccount {
        private int id;
        private double balance;

        public int ID{
            get => id;
            set => id = value;
        }

        public double Balance {
            get => balance;
            set => balance = value;
        }

        public void Deposit(Double amount){
            balance += amount;
        }
        public void Withdraw(Double amount){
            
            balance -= amount;
        }

        public override string ToString() {
            return $"Bank account id: {id}; balance: {balance:f2}";
        }
    }
}
