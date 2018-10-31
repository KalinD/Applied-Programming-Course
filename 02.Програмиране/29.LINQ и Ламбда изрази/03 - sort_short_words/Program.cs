using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_short_words {
    class Program {
        static void Main(string[] args) {
            List<string> input = Console.ReadLine().ToLower().Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '}).Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();
            Console.WriteLine(string.Join(", ", input.Skip(1)));

        }
    }
}
