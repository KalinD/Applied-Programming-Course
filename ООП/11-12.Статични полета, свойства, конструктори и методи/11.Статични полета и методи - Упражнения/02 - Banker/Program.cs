using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker {
    class Program {
        static void Main(string[] args) {
            BankAccount acc1 = new BankAccount();
            acc1.ID = 1;
            acc1.Balance = 420.42;
            BankAccount acc2 = new BankAccount();
            acc2.ID = 2;
            acc2.Balance = 42.69;
            Bank.AddAccount(acc1);
            Bank.AddAccount(acc2);
            Bank.Deposit(1, 270);
            Bank.WithDraw(2, -10);
            Bank.WithDraw(3, 10);
            Bank.Deposit(1, -20);
            Bank.WithDraw(2, 50);
            Bank.WithDraw(2, 42);
            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2.ToString());
        }
    }
}
