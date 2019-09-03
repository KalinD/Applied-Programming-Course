using System;
using System.Collections.Generic;
using System.Text;
using TileRepairs.Models;
using TileRepairs.Views;

namespace TileRepairs.Controllers {
    class Controller {
        private Display display;
        private Ground ground;
        private Plate plate;
        private Bench bench;
        public Controller() {
            display = new Display();
            ground = new Ground(display.Side);
            plate = new Plate(display.PlateHeight, display.PlateWidth);
            bench = new Bench(display.BenchHeight, display.BenchWidth);
        }

        public void Start() {
            int groundArea = ground.CalculateArea();
            int benchArea = bench.CalculateArea();
            int totalArea = groundArea - benchArea;
            double plateArea = plate.CalculateArea();

            display.PlateCount = totalArea / plateArea;
            display.Time = display.PlateCount * plate.PlacementTime;

            display.PrintResult();
        }
    }
}
