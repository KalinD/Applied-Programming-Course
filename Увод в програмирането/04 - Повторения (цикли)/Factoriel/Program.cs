﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int final = 1;
            for (int i = 1; i <= n; ++i) {
                final *= i;
            }
            Console.WriteLine(final);
        }
    }
}
