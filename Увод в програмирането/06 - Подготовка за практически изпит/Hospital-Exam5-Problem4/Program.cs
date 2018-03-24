using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Exam5_Problem4 {
    class Program {
        static void Main(string[] args) {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treated = 0;
            int untreated = 0;
            for(int i = 1; i <= days; i++){
                if(treated < untreated && i % 3 == 0){
                    doctors++;
                }
                int today = int.Parse(Console.ReadLine());
                untreated += today;
                treated += today < doctors ? today : doctors;
                untreated -= today < doctors ? today : doctors;
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
