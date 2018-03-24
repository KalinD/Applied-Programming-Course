using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before swap:\na = {a}\nb = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swap:\na = {a}\nb = {b}");
        }
    }
}
