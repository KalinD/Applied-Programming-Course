using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Rad_Deg {
    class Program {
        static void Main(string[] args) {
            float rad = float.Parse(Console.ReadLine());
            double deg = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(deg, 2));
        }
    }
}
