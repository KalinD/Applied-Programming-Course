using System;
using System.Collections.Generic;
using System.Text;

namespace Histogram.Views {
    class Display {
        private int amount;
        private List<int> numbers;

        public List<int> Numbers { get => numbers; set => numbers = value; }
        public int Amount { get => amount; set => amount = value; }

        public Display() {
            Numbers = new List<int>();
            GetValues();
        }

        private void GetValues() {
            Amount = int.Parse(Console.ReadLine());
            for(int i = 0; i < Amount; i++) {
                Numbers.Add(int.Parse(Console.ReadLine()));
            }
        }

        public void PrintResults(List<double> results) {
            for(int i = 0; i < 5; i++) {
                Console.WriteLine($"{results[i]:f2}%");
            }
        }
    }
}
