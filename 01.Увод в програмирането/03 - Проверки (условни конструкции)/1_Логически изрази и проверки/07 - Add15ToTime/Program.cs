using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add15ToTime {
    class Program {
        static void Main(string[] args) {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes >= 60) {
                hour++;
            }
            hour %= 24;
            minutes %= 60;
            Console.WriteLine($"{hour}:{minutes.ToString("00")}");
        }
    }
}
