using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_ingredients {
    class Program {
        static void Main(string[] args)
        {
            List<string> ingredients = Console.ReadLine().Split(' ').ToList();
            List<string> validIngredients = new List<string>();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            foreach(string ingredient in ingredients){
                if(ingredient.Length == n){
                    Console.WriteLine($"Adding {ingredient}.");
                    count ++;
                    validIngredients.Add(ingredient);
                }
                if(count == 10){
                    break;
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", validIngredients)}.");
        }
    }
}

