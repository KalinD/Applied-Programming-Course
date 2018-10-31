using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_list_from_one_row_input {
    class Program {
        static void Main(string[] args) {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < input.Count; i++) {
                Console.WriteLine($"list[{i}] = {input[i]}");
            }
        }
    }
}

