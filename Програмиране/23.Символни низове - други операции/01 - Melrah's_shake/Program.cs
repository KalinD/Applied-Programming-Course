using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melrah_s_shake {
    class Program {
        static void Main(string[] args) {
            string symbols = Console.ReadLine();
            string remove = Console.ReadLine();
            while (true) {
                int index = symbols.IndexOf(remove);
                if (index == -1) {
                    Console.WriteLine("No shake.");
                    break;
                }
                symbols = symbols.Remove(index, remove.Length);
                Console.WriteLine("Shaked it!");
            }
            Console.WriteLine(string.Join("", symbols));
        }
    }
}
