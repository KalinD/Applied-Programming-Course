using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_calories {
    class Program {
        static void Main(string[] args) {
            List<Dough> doughs = new List<Dough>();
            List<Pizza> pizzas = new List<Pizza>();
            List<Topping> toppings = new List<Topping>();
            int count = 0;
            while(true){
                List<string> input = Console.ReadLine().Split().ToList();
                if(input[0] == "END"){
                    break;
                }
                switch (input[0]) {
                    case "Dough":
                        try{
                            Dough dough = new Dough(input[1], input[2], double.Parse(input[3]));
                            doughs.Add(dough);
                            if(count > 0){
                                pizzas[pizzas.Count - 1].Dough = dough;
                            }
                        }
                        catch(ArgumentException e){
                            Console.WriteLine(e.Message);
                            if (count > 0) {
                                pizzas.RemoveAt(pizzas.Count - 1);
                                count = 0;
                            }
                        }
                        break;
                    case "Topping":
                        try{
                            Topping topping = new Topping(input[1], double.Parse(input[2]));
                            toppings.Add(topping);
                            if(count > 0){
                                pizzas[pizzas.Count - 1].Toppings.Add(topping);
                                count--;
                            }
                        }
                        catch(ArgumentException e){
                            Console.WriteLine(e.Message);
                            if(count > 0){
                                pizzas.RemoveAt(pizzas.Count - 1);
                                count = 0;
                            }
                        }
                        break;
                    case "Pizza":
                        try{
                            Pizza pizza = new Pizza(input[1]);
                            count = int.Parse(input[2]);
                            pizzas.Add(pizza);
                        }
                        catch(ArgumentException e){
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach(Pizza pizza in pizzas){
                Console.WriteLine($"{pizza.Name} - {pizza.Calories():f2}");
            }
        }
    }
}
