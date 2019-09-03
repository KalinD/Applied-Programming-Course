using OnTimeForExam.Controllers;
using System;

namespace OnTimeForExam {
    class Program {
        static void Main(string[] args) {
            Controller controller = new Controller();
            controller.Run();
        }
    }
}
