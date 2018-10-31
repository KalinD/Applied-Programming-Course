using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea {
    class Program {
        static void Main(string[] args) {
            string figure = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            if (figure == "square") {
                Console.WriteLine(Math.Round(a * a, 3));
            }
            else if (figure == "rectangle") {
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * b, 3));
            }
            else if (figure == "circle") {
                Console.WriteLine(Math.Round(Math.PI * Math.Pow(a, 2), 3));
            }
            else if (figure == "triangle") {
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * h / 2), 3));
            }
        }
    }
}
