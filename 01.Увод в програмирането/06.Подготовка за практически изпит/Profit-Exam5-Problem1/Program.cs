using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_Exam5_Problem1 {
    class Program {
        static void Main(string[] args) {
            int workdays = int.Parse(Console.ReadLine());
            float earned = float.Parse(Console.ReadLine());
            float course = float.Parse(Console.ReadLine());
            float per_month = workdays * earned;
            double per_year = per_month * 14.5;
            double money = per_year - per_year / 4;
            money *= course;
            double per_day = Math.Round(money / 365, 2);
            Console.WriteLine(per_day);
        }
    }
}
