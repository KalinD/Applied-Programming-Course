using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Exam4_Problem1 {
    class Program {
        static void Main(string[] args) {
            int bitcoins = int.Parse(Console.ReadLine());
            float chinese = float.Parse(Console.ReadLine());
            float tax = float.Parse(Console.ReadLine());
            double money = bitcoins * 1168;
            double dolars = chinese * 0.15;
            money += dolars * 1.76;
            money /= 1.95;
            money -= money * tax / 100;
            Console.WriteLine(money);
        }
    }
}
