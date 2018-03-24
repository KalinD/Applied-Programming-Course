using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature_converter {
    class Program {
        static void Main(string[] args) {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("{0:f2}", celsius);
        }
        static double FahrenheitToCelsius(double temperature) {
            return (temperature - 32) * 5 / 9;
        }
    }
}
