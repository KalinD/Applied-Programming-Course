using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_C_F {
    class Program {
        static void Main(string[] args) {
            float C = float.Parse(Console.ReadLine());
            double F = C * 1.8 + 32;
            Console.WriteLine(F);
        }
    }
}
