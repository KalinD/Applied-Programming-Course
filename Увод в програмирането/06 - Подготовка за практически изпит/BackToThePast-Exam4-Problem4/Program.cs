﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast_Exam4_Problem4 {
    class Program {
        static void Main(string[] args) {
            int age = 18;
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            for(int i = 1800; i <= year; i++){
                if(i % 2 == 0){
                    money -= 12000;
                }
                else{
                    money -= 12000 + 50 * age;
                }
                age++;
            }
            if(money >= 0){
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else{
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
        }
    }
}
