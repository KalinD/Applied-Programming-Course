﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Of_2 {
    class Program {
        static void Main(string[] args) {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(number1, number2));
        }
    }
}
