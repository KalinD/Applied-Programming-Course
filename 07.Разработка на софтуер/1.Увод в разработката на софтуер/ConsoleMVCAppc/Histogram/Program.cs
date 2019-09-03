using Histogram.Controllers;
using System;

namespace Histogram {
    class Program {
        static void Main(string[] args) {
            HistogramController controller = new HistogramController();
            controller.Run();
        }
    }
}
