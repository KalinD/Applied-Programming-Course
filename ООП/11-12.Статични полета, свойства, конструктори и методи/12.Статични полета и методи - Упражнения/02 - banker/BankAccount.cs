using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banker {
    class BankAccount {
        int id;
        double balance;
        
        public int ID => id;
        public double Balance => balance;

        public BankAccount(int id, double balance){
            this.id = id;
            this.balance = balance;
        }

        public void Deposit(Double amount){
            if(amount <= 0){
                throw new ArgumentException("Amount to deposit must be positive!");
            }
            balance += amount;
        }
        
        public void Withdraw(Double amount){
            if(amount <= 0){
                throw new ArgumentException("Amount to withdraw must be positive!");
            }
            if(Balance - amount >= 0){
                balance -= amount;
            }
            else{
                throw new ArgumentException("Not enough money in account!");
            }
        }

        public override string ToString() {
            return $"{ID} - {Balance}";
        }
    }
}
