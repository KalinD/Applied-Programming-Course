using System;

namespace pizza_calories {
    internal class Dough {
        private string flour;
        private string bakingTechnique;
        private double multiplier = 2;
        private double weight;

        private string Flour{
            set {
                switch (value) {
                    case "White":
                        multiplier *= 1.5;
                        break;
                    case "Wholegrain":
                        multiplier *= 1;
                        break;
                    default:
                        throw new ArgumentException("Invalid type of dough.");
                }
                flour = value;
            }
        }

        private string BakingTechnique{
            set{
                switch (value) {
                    case "Crispy":
                        multiplier *= 0.9;
                        break;
                    case "Chewy":
                        multiplier *= 1.1;
                        break;
                    case "Homemade":
                        multiplier *= 1;
                        break;
                    default:
                        throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        private double Weight {
            set {
                if (value < 1 || value > 200) {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public Dough(string flour, string bakingTechnique, double weight){
            Flour = flour;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public double Calories(){
            return weight * multiplier; 
        }
    }
}


