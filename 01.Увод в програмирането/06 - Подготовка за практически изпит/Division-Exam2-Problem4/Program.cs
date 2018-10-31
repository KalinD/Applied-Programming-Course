using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Exam2_Problem4 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 0; i < n; i++){
                int num = int.Parse(Console.ReadLine());
                if(num % 2 == 0){
                    p1++;
                    if(num % 4 == 0){
                        p3++;
                    }
                }
                if(num % 3 == 0){
                    p2++;
                }
            }
            Console.WriteLine($"{(p1 / n) * 100:f2}%\n{(p2 / n) * 100:f2}%\n{(p3 / n) * 100:f2}%");
        }
    }
}