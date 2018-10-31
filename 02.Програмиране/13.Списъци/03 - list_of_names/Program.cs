using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_of_names {
    class Program {
        static void Main(string[] args) {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            names.Reverse();
            Console.WriteLine(string.Join("; ", names));
        }
    }
}
