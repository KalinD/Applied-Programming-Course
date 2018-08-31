using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace root_request {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++){
                Console.WriteLine(Root.GetRoot(double.Parse(Console.ReadLine())));
            }
        }
    }
}
