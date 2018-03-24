using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoint {
    class Program {
        static void Main(string[] args) {
            double points = double.Parse(Console.ReadLine());
            double bonusP = 0.0;
            if (points <= 100) {
                bonusP += 5;
            }
            else if (points >= 1000) {
                bonusP += (points * 10 / 100);
            }
            else {
                bonusP += (points * 20 / 100);
            }
            if (points % 2 == 0) {
                bonusP += 1;
            }
            else if (points % 10 == 5) {
                bonusP += 2;
            }
            Console.WriteLine(bonusP);
            Console.WriteLine(bonusP + points);
        }
    }
}
