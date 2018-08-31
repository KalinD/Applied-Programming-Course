using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_bankAccount_class {
    class Program {
        static void Main(string[] args) {
            BankAccount acc = new BankAccount();
            acc.ID = 1;
            acc.Balance = 15;
            Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");

            BankAccount acc1 = new BankAccount();
            acc1.ID = 2;
            acc1.Balance = 30;
            Console.WriteLine($"Account {acc1.ID}, balance {acc1.Balance}");

            Person firstPerson = new Person();
            firstPerson.Name = "Pesho";
            firstPerson.Age = 30;
            firstPerson.Accounts.Add(acc);
            firstPerson.Accounts.Add(acc1);
            Console.WriteLine(firstPerson.GetBalance());
        }
    }
}
