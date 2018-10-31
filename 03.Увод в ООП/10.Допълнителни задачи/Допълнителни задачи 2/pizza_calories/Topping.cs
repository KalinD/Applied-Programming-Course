using System;

namespace pizza_calories {
    internal class Topping {
        private string type;
        private double multiplier = 2;
        private double weight;

        private string Type{
            set{
                switch (value) {
                    case "Meat":
                        multiplier *= 1.2;
                        break;
                    case "Veggies":
                        multiplier *= 0.8;
                        break;
                    case "Cheese":
                        multiplier *= 1.1;
                        break;
                    case "Sauce":
                        multiplier *= 0.9;
                        break;
                    default:
                        throw new ArgumentException($"Cannot place {value} on top of your pizza");
                }
                type = value;
            }
        }
        private double Weight{
            set{
                if(value < 1 || value > 50){
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public Topping(string type, double weight){
            Type = type;
            Weight = weight;
        }

        public double Calories(){
            return multiplier * weight;
        }
    }
}