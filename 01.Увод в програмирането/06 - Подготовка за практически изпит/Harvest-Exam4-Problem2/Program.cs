using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Exam4_Problem2 {
    class Program {
        static void Main(string[] args) {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double total = X * Y;
            double wine = total * 40 / 100 / 2.5;
            if (wine >= Z) {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - Z)} liters left -> {Math.Ceiling((wine - Z) / workers)} liters per person");
            }
            else {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(Z - wine)} liters wine needed.");
            }
        }
    }
}
