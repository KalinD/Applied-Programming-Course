using System;
using System.Collections.Generic;
using System.Text;

namespace PoolPipes.Views {
    class Display {
        private int volume;
        private int pipe1;
        private int pipe2;
        private double hours;

        public double Hours { get => hours; set => hours = value; }
        public int Pipe2 { get => pipe2; set => pipe2 = value; }
        public int Pipe1 { get => pipe1; set => pipe1 = value; }
        public int Volume { get => volume; set => volume = value; }

        public Display() {
            GetValues();
        }

        private void GetValues() {
            Volume = int.Parse(Console.ReadLine());
            Pipe1 = int.Parse(Console.ReadLine());
            Pipe2 = int.Parse(Console.ReadLine());
            Hours = double.Parse(Console.ReadLine());
        }

        public void PrintResult(string result) {
            Console.WriteLine(result);
        }
    }
}
