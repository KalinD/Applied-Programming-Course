using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_person_and_his_money {
    class Program {
        static void Main(string[] args) {
            Person firstPerson = new Person();
            firstPerson.Name = "Kalin";
            firstPerson.Age = 16;

            BankAccount acc1 = new BankAccount();
            acc1.ID = 1;
            acc1.Balance = 20;

            BankAccount acc2 = new BankAccount();
            acc2.ID = 2;
            acc2.Balance = 60;

            BankAccount acc3 = new BankAccount();
            acc3.ID = 3;
            acc3.Balance = 120;

            firstPerson.Accounts.Add(acc1);
            firstPerson.Accounts.Add(acc2);
            firstPerson.Accounts.Add(acc3);
            Console.WriteLine(firstPerson.GetBalance());
        }
    }
}
