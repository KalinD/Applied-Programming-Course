using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm_Exam5_Problem2 {
    class Program {
        static void Main(string[] args) {
            int needed_hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double workDays = days - days / 10.0;
            double workHours = workDays * 8;
            double hours = Math.Floor(workHours + workers * 2 * days);
            if (hours >= needed_hours) {
                Console.WriteLine($"Yes!{hours - needed_hours} hours left.");
            }
            else {
                Console.WriteLine($"Not enough time!{needed_hours - hours} hours needed.");
            }
        }
    }
}
