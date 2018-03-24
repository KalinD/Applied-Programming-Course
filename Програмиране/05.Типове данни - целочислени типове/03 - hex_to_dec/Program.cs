using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hex_to_dec {
    class Program {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int number = Convert.ToInt32(input, 16);
            Console.WriteLine(number);
        }
    }
}
