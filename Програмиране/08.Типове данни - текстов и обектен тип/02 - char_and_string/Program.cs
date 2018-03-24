using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_and_string {
    class Program {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            char fourth = char.Parse(Console.ReadLine());
            string fifth = Console.ReadLine();
            Console.WriteLine($"{first}\n{second}\n{third}\n{fourth}\n{fifth}");
        }
    }
}
