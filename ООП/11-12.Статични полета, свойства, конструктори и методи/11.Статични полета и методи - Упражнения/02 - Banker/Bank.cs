using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker {
    static class Bank {
        private static List<BankAccount> accounts;

        static Bank(){
            accounts = new List<BankAccount>();
        }

        public static void AddAccount(BankAccount acc){
            accounts.Add(acc);
        }

        public static void WithDraw(int id, double amount){
            if(amount <= 0){
                Console.WriteLine("Withdraw amount must be positive");
            }
            else{
                foreach(var account in accounts){
                    if(account.ID == id && account.Balance >= amount){
                        account.Balance -= amount;
                        Console.WriteLine($"Withdrew {amount} from account with id: {id}");
                        return;
                    }
                }
                Console.WriteLine("Account not found or not enough money in the account");
            }
        }

        public static void Deposit(int id, double amount) {
            if (amount <= 0) {
                Console.WriteLine("Deposit amount must be positive");
            }
            else {
                foreach (var account in accounts) {
                    if (account.ID == id && account.Balance >= amount) {
                        account.Balance += amount;
                        Console.WriteLine($"Deposited {amount} to account with id: {id}");
                        return;
                    }
                }
                Console.WriteLine("Account not found or not enough money in the account");
            }
        }
    }
}
