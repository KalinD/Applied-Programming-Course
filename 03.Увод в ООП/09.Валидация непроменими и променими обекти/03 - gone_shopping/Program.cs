using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gone_shopping {
    class Program {
        static void Main(string[] args) {

            Dictionary<string, Person> people = new Dictionary<string, Person>();
            List<string> input = Console.ReadLine().Split(new char[] { '=', ';' }).ToList();
            for(int i = 0; i < input.Count; i++){
                Person person = new Person();
                try{
                    person.Name = input[i];
                    person.Money = double.Parse(input[i + 1]);
                }
                catch(ArgumentException e){
                    Console.WriteLine(e.Message);
                }
                people[input[i++]] = person;
            }

            List<Product> products = new List<Product>();
            input = Console.ReadLine().Split(new char[] { '=', ';' }).ToList();
            input.RemoveAll(x => x == "");
            for (int i = 0; i < input.Count; i++) {
                Product product = new Product();
                product.Name = input[i++];
                product.Price = double.Parse(input[i]);
                products.Add(product);
            }

            while (true){
                List<string> command = Console.ReadLine().Split().ToList();
                if(command[0] == "END"){
                    break;
                }
                foreach(Product product in products){
                    if(product.Name == command[1] && people[command[0]].Money >= product.Price){
                        people[command[0]].Money -= product.Price;
                        people[command[0]].Products.Add(products[products.IndexOf(product)]);
                        Console.WriteLine($"{command[0]} bought {command[1]}");
                    }
                    else if(product.Name == command[1] && people[command[0]].Money < product.Price){
                        Console.WriteLine($"{command[0]} can't afford {command[1]}");
                    }
                }
            }
            foreach(var person in people){
                if(person.Value.Products.Count > 0){
                    Console.WriteLine($"{person.Key} - {person.Value.ToString()}");
                }
                else{
                    Console.WriteLine($"{person.Key} - Nothing bought");
                }
            }
        }
    }
}
