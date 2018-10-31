using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_shop {
    class Program {
        static void Main(string[] args) {
            while(!false){
                List<string> command = Console.ReadLine().Split().ToList();
                switch (command[0]) {
                    case "Sell":
                        Shop.Sell(command[1], double.Parse(command[2]));
                        break;
                    case "Add":
                        Shop.Add(command[1], command[2], double.Parse(command[3]), double.Parse(command[4]));
                        break;
                    case "Update":
                        Shop.Update(command[1], double.Parse(command[2]));
                        break;
                    case "PrintA":
                        Shop.PrintA();
                        break;
                    case "PrintU":
                        Shop.PrintU();
                        break;
                    case "PrintD":
                        Shop.PrintD();
                        break;
                    case "Calculate":
                        Console.WriteLine(Shop.Calculate());
                        return;
                }
            }
        }
    }
}
