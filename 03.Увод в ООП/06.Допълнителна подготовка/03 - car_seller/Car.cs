using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_seller {
    class Car {
        //model, engine, weight, color
        private string model;
        private Engine engine;
        private double weight;
        private string color;

        public string Model{
            get{
                return model;
            }
            set{
                model = value;
            }
        }

        public Engine EngineType {
            get {
                return engine;
            }
            set {
                engine = value;
            }
        }

        public double Weight {
            get {
                return weight;
            }
            set {
                weight = value;
            }
        }

        public string Color {
            get {
                return color;
            }
            set {
                color = value;
            }
        }

        public Car(){
            engine = new Engine();
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(model + ":\n");
            sb.Append("  " + engine.Model + ":\n");
            sb.Append(engine.ToString());
            if (weight != 0){
                sb.Append("  Weight: " + weight + "\n");
            }
            else{
                sb.Append("  Weight: n/a\n");
            }
            if(color != null){
                sb.Append("  Color: " + color + "\n");
            }
            else {
                sb.Append("  Color: n/a \n");
            }
            return sb.ToString();
        }
    }
}
