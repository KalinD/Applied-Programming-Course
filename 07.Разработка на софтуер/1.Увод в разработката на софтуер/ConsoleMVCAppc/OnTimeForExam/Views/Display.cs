using System;
using System.Collections.Generic;
using System.Text;

namespace OnTimeForExam.Views {
    class Display {
        private TimeSpan arrivalTime;
        private TimeSpan examTime;

        public TimeSpan ArrivalTime { get => arrivalTime; set => arrivalTime = value; }
        public TimeSpan ExamTime { get => examTime; set => examTime = value; }

        public Display() {
            GetValues();
        }

        private void GetValues() {
            arrivalTime = new TimeSpan(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), 0);
            examTime = new TimeSpan(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), 0);
        }

        public void PrintResult(string result) {
            Console.WriteLine(result);
        }
    }
}
