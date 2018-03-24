using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets_Exam4_Problem3 {
    class Program {
        static void Main(string[] args) {
            double money = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            if (people <= 4) {
                money -= money * 75 / 100;
            }
            else if (people <= 9) {
                money -= money * 0.6;
            }
            else if (people <= 24) {
                money -= money / 2;
            }
            else if (people <= 49) {
                money -= money * 0.4;
            }
            else {
                money -= money / 4;
            }
            double price = category == "VIP" ? 499.99 * people : 249.99 * people;
            if (money > price) {
                Console.WriteLine($"Yes!You have {money - price:f2} leva left.");
            }
            else {
                Console.WriteLine($"Not enough money! You need {price - money:f2} leva");
            }
        }
    }
}
