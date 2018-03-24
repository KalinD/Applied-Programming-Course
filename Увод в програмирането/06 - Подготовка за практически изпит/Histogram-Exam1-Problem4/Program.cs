using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram_Exam1_Problem4 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < n; i++) {
                int num = int.Parse(Console.ReadLine());
                if (num < 200) {
                    p1++;
                }
                else if (num < 400) {
                    p2++;
                }
                else if (num < 600) {
                    p3++;
                }
                else if (num < 800) {
                    p4++;
                }
                else {
                    p5++;
                }
            }
            p1 /= n * 0.01;
            p2 /= n * 0.01;
            p3 /= n * 0.01;
            p4 /= n * 0.01;
            p5 /= n * 0.01;
            Console.WriteLine($"{p1:f2}%\n{p2:f2}%\n{p3:f2}%\n{p4:f2}%\n{p5:f2}%");
        }
    }
}
