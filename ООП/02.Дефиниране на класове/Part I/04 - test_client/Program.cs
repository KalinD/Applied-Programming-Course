using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_client {
    class Program {
        static void Main(string[] args) {
            List<BankAccount> accounts = new List<BankAccount>();
            bool repeat = true;
            while(repeat){
                List<string> command = Console.ReadLine().Split(' ').ToList();
                switch (command[0]) {
                    case "Create":
                        foreach (var account in accounts) {
                            if(account.ID == int.Parse(command[1])){
                                Console.WriteLine("Account already exists");
                                break;
                            }
                        }
                        BankAccount acc = new BankAccount();
                        acc.ID = int.Parse(command[1]);
                        accounts.Add(acc);
                        break;
                    case "Deposit":
                        if(int.Parse(command[1]) - 1 >= accounts.Count) {
                            Console.WriteLine("Account does not exist");
                            break;
                        }
                        accounts[int.Parse(command[1])].Deposit(double.Parse(command[2]));
                        break;
                    case "Withdraw":
                        if (int.Parse(command[1]) - 1 >= accounts.Count) {
                            Console.WriteLine("Account does not exist");
                            break;
                        }
                        accounts[int.Parse(command[1])].Withdraw(double.Parse(command[2]));
                        break;
                    case "Print":
                        if (int.Parse(command[1]) - 1 >= accounts.Count) {
                            Console.WriteLine("Account does not exist");
                            break;
                        }
                        Console.WriteLine(accounts[int.Parse(command[1])].ToString());
                        break;
                    case "End":
                        repeat = false;
                        break;
                }
            }
        }
    }
}
