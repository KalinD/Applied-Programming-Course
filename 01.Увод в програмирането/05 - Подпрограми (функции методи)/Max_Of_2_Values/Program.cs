using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Of_2_Values {
    class Program {
        static void Main(string[] args) {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            type.CompareTo(a);
            Console.WriteLine(GetMax(a, b));
        }
        static string GetMax(string a, string b) {
            try {
                double a1 = Convert.ToDouble(a);
                double b1 = Convert.ToDouble(b);
                if (a1 < b1) {
                    return b;
                }
                else {
                    return a;
                }
            }
            catch {
                if (a.CompareTo(b) == 1) {
                    return a;
                }
                else {
                    return b;
                }
            }
        }
    }
}
