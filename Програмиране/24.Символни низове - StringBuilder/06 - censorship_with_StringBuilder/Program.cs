using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace censorship_with_StringBuilder {
    class Program {
        static void Main(string[] args) {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            StringBuilder edited = new StringBuilder(input.Length);
            edited.Append(input);
            edited.Replace(word, new string('*', word.Length));
            Console.WriteLine(edited.ToString());
        }
    }
}
