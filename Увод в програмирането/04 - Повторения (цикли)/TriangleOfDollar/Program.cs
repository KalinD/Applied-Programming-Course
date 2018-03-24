using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfDollar {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int j = 0;
                while (j < i) {
                    Console.Write("$ ");
                    j++;
                }
                Console.WriteLine("$");
            }
        }
    }
}
