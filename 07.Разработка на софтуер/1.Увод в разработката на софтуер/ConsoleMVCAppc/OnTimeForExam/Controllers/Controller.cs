using OnTimeForExam.Models;
using OnTimeForExam.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnTimeForExam.Controllers {
    class Controller {
        private Display display;
        private Student student;

        internal Display Display { get => display; set => display = value; }
        internal Student Student { get => student; set => student = value; }

        public Controller() {
            Display = new Display();
            Student = new Student();
        }

        public void Run() {
            Student.ArrivaTime = Display.ArrivalTime;
            Student.ExamTime = Display.ExamTime;
            string result = Student.GetOutputString();
            Display.PrintResult(result);
        }
    }
}
