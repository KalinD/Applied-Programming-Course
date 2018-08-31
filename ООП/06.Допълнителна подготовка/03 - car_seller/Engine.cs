using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_seller {
    class Engine {
        //model, power, displacement, efficiency
        private string model;
        private double power;
        private double displacement;
        private string efficiency;
        public string Model{
            get{
                return model;
            }
            set{
                model = value;
            }
        }

        public double Power {
            get {
                return power;
            }
            set {
                power = value;
            }
        }

        public double Displacement {
            get {
                return displacement;
            }
            set {
                displacement = value;
            }
        }

        public string Efficiency {
            get {
                return efficiency;
            }
            set {
                efficiency = value;
            }
        }

        public Engine(string model, double power, double displacment, string efficiency){
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public Engine(string model, double power) : this(model, power, new double(), null) {
        }
        public Engine() : this(null, new double(), new double(), null){
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("    Power: " + power + "\n");
            if (displacement != 0) {
                sb.Append("    Displacement: " + displacement + "\n");
            }
            else {
                sb.Append("    Displacement: n/a\n");
            }
            if (efficiency != null) {
                sb.Append("    Efficiency: " + efficiency + "\n");
            }
            else {
                sb.Append("    Efficiency: n/a\n");
            }
            return sb.ToString();
        }
    }
}
