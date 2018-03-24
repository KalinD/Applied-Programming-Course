﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer_s_sign {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
            n = int.Parse(Console.ReadLine());
            PrintSign(n);
            n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        static void PrintSign(int n){
            if(n > 0){
                Console.WriteLine($"The number {n} is positive.");
            }
            else if(n < 0){
                Console.WriteLine($"The number {n} is negative.");
            }
            else{
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
