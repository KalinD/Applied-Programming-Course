using Histogram.Models;
using Histogram.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Histogram.Controllers {
    class HistogramController {
        private ListNumbers numbers;
        private Display display;

        internal ListNumbers Numbers { get => numbers; set => numbers = value; }
        internal Display Display { get => display; set => display = value; }

        public HistogramController() {
            Display = new Display();
            Numbers = new ListNumbers();
        }

        public void Run() {
            Numbers.Numbers = Display.Numbers;
            List<double> results = Numbers.GetPercentages();
            Display.PrintResults(results);
        }
    }
}
