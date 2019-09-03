using System;
using System.Collections.Generic;
using System.Text;

namespace TileRepairs.Views {
    class Display {
        public int Side { get; set; }
        public double PlateWidth { get; set; }
        public double PlateHeight { get; set; }
        public int BenchWidth { get; set; }
        public int BenchHeight { get; set; }
        public double PlateCount { get; set; }
        public double Time { get; set; }

        public Display() {
            GetValues();
        }

        private void GetValues() {
            Side = int.Parse(Console.ReadLine());
            PlateWidth = double.Parse(Console.ReadLine());
            PlateHeight = double.Parse(Console.ReadLine());
            BenchWidth = int.Parse(Console.ReadLine());
            BenchHeight = int.Parse(Console.ReadLine());
        }

        public void PrintResult() {
            Console.WriteLine(PlateCount);
            Console.WriteLine(Time);
        }
    }
}
