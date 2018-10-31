using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banker {
    static class Bank {
        static public void WithdrawBalance(int id, List<BankAccount> accounts, double amount){
            BankAccount acc = FindAccount(id, accounts);
            if(acc == null){
                throw new ArgumentException("There isn't an account with that id");
            }
            else{
                acc.Withdraw(amount);
            }
        }

        static public void DepositBalance(int id, List<BankAccount> accounts, double amount) {
            BankAccount acc = FindAccount(id, accounts);
            if (acc == null) {
                throw new ArgumentException("There isn't an account with that id");
            }
            else {
                acc.Deposit(amount);
            }
        }

        static private BankAccount FindAccount(int id, List<BankAccount> accounts){
            foreach (BankAccount account in accounts) {
                if (account.ID == id) {
                    return account;
                }
            }
            return null;
        }
    }
}
