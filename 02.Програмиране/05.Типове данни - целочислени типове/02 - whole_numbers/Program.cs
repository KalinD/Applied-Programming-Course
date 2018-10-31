using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whole_numbers {
    class Program {
        static void Main(string[] args)
        {
            sbyte first = sbyte.Parse(Console.ReadLine()); //-100
            byte second = byte.Parse(Console.ReadLine()); //128
            short third = short.Parse(Console.ReadLine()); //-3540
            ushort fourth = ushort.Parse(Console.ReadLine()); //64876
            uint fifth = uint.Parse(Console.ReadLine()); //2147483648
            int sixth = int.Parse(Console.ReadLine()); //-1141583228
            long seventh = long.Parse(Console.ReadLine()); //-1223372036854775808
            Console.WriteLine($"{first}\n{second}\n{third}\n{fourth}\n{fifth}\n{sixth}\n{seventh}");
        }
    }
}
