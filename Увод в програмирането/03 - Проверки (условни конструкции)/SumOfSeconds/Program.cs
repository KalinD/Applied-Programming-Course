using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSeconds {
    class Program {
        static void Main(string[] args) {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            int time = time1 + time2 + time3;
            Console.WriteLine($"{time / 60}:{(time % 60).ToString("00")}");
        }
    }
}
