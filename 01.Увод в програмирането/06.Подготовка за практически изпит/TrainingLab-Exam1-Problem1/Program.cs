using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab_Exam1_Problem1 {
    class Program {
        static void Main(string[] args) {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            h *= 100;
            w *= 100;
            h -= 100;
            int count_h = (int)Math.Floor(h / 70);
            int count_w = (int)Math.Floor(w / 120);
            Console.WriteLine(count_h * count_w - 3);
        }
    }
}
