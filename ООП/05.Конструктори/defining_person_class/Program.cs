using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_person_class {
    class Program {
        static void Main(string[] args) {
            Person person1 = new Person("Pesho", 20);
            List<BankAccount> accounts1 = new List<BankAccount>();
            BankAccount acc = new BankAccount("12343", 250);
            accounts1.Add(acc);
            person1.Accounts = accounts1;
            Person person2 = new Person("123", 125);
            BankAccount acc1 = new BankAccount("12223", 250);
            BankAccount acc2 = new BankAccount("12224", 430.5);
            List<BankAccount> accounts2 = new List<BankAccount>();
            accounts2.Add(acc1);
            accounts2.Add(acc2);
            person2.Accounts = accounts2;
            Console.WriteLine(person1.Balance());
            Console.WriteLine(person2.Balance());
        }
    }
}
