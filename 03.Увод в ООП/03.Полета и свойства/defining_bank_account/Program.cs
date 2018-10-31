using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_bank_account {
    class Program {
        static void Main(string[] args) {
            BankAccount acc = new BankAccount();
            acc.ID = 1;
            acc.Balance = 15;
            Console.WriteLine($"Account ID{acc.ID}, balance{acc.Balance}");
        }
    }
}
