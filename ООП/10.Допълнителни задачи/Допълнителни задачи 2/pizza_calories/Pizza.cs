using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_calories {
    class Pizza {
        //име, тесто и гарнитурата
        private string name;
        private int toppingsAmount;
        private Dough dough;
        private List<Topping> toppings;

        public string Name{
            get => name;
            set{
                if(value.Length > 15 || value.Length <= 0){
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Dough Dough{
            get => dough;
            set => dough = value;
        }

        public List<Topping> Toppings{
            get => toppings;
            set => toppings = value;
        }

        public int ToppingsAmount{
            get => toppingsAmount;
            set{
                if(value <= 0 || value > 10){
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                toppingsAmount = value;
            }
        }

        public Pizza(string name){
            Name = name;
            toppings = new List<Topping>();
        }
        
        public double Calories(){
            double calories = 0;
            calories += dough.Calories();
            foreach(Topping topping in toppings){
                calories += topping.Calories();
            }
            return calories;
        }
    }
}
