using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec_to_hex_and_bi {
    class Program {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string txt = Convert.ToString(num, 16);
            Console.WriteLine(txt.ToUpper());
            txt = Convert.ToString(num, 2);
            Console.WriteLine(txt);
        }
    }
}
