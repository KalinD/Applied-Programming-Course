using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banker {
    class Program {
        static void Main(string[] args) {
            BankAccount acc1 = new BankAccount(1, 100);
            BankAccount acc2 = new BankAccount(2, 10);
            BankAccount acc3 = new BankAccount(3, 0);
            List<BankAccount> accounts = new List<BankAccount> {acc1, acc2, acc3};
            try{
                Bank.WithdrawBalance(2, accounts, 8);
                Bank.WithdrawBalance(3, accounts, 10);
            }
            catch(ArgumentException e){
                Console.WriteLine(e.Message);
            }
            try{
                Bank.WithdrawBalance(2, accounts, -2);
            }
            catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            try{
                Bank.WithdrawBalance(4, accounts, 2);
            }
            catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            try{
                Bank.DepositBalance(3, accounts, 3);
                Bank.DepositBalance(4, accounts, 8);
            }
            catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            try{
                Bank.DepositBalance(2, accounts, -2);
            }
            catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            foreach(BankAccount acc in accounts){
                Console.WriteLine(acc.ToString());
            }
        }
    }
}
