using ConsoleMVC.Controllers;
using System;

namespace ConsoleMVC {
    class Program {
        static void Main(string[] args) {
            TipCalculatorController controller = new TipCalculatorController();

            controller.CalculateTotal();
        }
    }
}
