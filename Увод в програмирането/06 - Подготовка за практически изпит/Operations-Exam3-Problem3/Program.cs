using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_Exam3_Problem3 {
    class Program {
        static void Main(string[] args) {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            if (symbol == '+') {
                string odEven = (num1 + num2) % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{num1} + {num2} = {num1 + num2} - {odEven}");
            }
            else if (symbol == '-') {
                string odEven = (num1 - num2) % 2 == 0 ? "Even" : "Odd";
                Console.WriteLine($"{num1} - {num2} = {num1 - num2} - {odEven}");
            }
            else if (symbol == '*') {
                string odEven = (num1 * num2) % 2 == 0 ? "Even" : "Odd";
                Console.WriteLine($"{num1} * {num2} = {num1 * num2} - {odEven}");
            }
            else if (symbol == '/') {
                if (num2 == 0) {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else {
                    Console.WriteLine($"{num1} / {num2} = {num1 / (double)num2}");
                }
            }
            else {
                if (num2 == 0) {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else {
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                }
            }
        }
    }
}
