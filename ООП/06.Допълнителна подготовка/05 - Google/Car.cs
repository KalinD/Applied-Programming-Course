using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google {
    class Car {
        private string model;
        private double speed;

        public string Model{
            get => model;
            set => model = value;
        }

        public double Speed {
            get => speed;
            set => speed = value;
        }

        public override string ToString() {
            if(model != null){
                return $"Car:\n{model} {speed}\n";
            }
            return "Car:\n";
        }
    }
}
