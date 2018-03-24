using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles {
    class Program {
        static void Main(string[] args) {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            if (sex == "f") {
                if (age >= 16) {
                    Console.WriteLine("Ms.");
                }
                else {
                    Console.WriteLine("Miss");
                }
            }
            else {
                if (age >= 16) {
                    Console.WriteLine("Mr.");
                }
                else {
                    Console.WriteLine("Master");
                }
            }
        }
    }
}
