using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_list_from_input {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();
            for (int i = 0; i < n; i++){
                input.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"list[{i}] = {input[i]}");
            }
        }
    }
}
