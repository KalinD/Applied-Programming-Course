using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat_Exam3_Problem2 {
    class Program {
        static void Main(string[] args) {
            int days = int.Parse(Console.ReadLine());
            int time = days * 127 + (365 - days) * 63;
            if(time <= 30000){
                Console.WriteLine($"Tom sleeps well\n{(30000 - time) / 60} hours and {(30000 - time) % 60} minutes less for play");
            }
            else {
                Console.WriteLine($"Tom will run away\n{(time - 30000) / 60} hours and {(time - 30000) % 60} minutes more for play");
            }
        }
    }
}
