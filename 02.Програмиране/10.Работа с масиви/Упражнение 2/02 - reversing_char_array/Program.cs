using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversing_char_array {
    class Program {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
