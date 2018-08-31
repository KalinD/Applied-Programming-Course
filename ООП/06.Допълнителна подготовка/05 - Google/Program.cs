using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            while(true){
                List<string> command = Console.ReadLine().Split().ToList();
                if(command[0] == "End"){
                    break;
                }
                if (!people.ContainsKey(command[0])) {
                    Person person = new Person();
                    person.Name = command[0];
                    people[command[0]] = person;
                }
                switch (command[1]) {
                    case "company":
                        Company company = new Company();
                        company.Name = command[2];
                        company.Department = command[3];
                        company.Payment = double.Parse(command[4]);
                        people[command[0]].CompanyType = company;
                        break;
                    case "pokemon":
                        Pokemon pokemon = new Pokemon();
                        pokemon.Name = command[2];
                        pokemon.Type = command[3];
                        people[command[0]].Pokemon.Add(pokemon);
                        break;
                    case "parents":
                        Parents parent = new Parents();
                        parent.Name = command[2];
                        parent.BDay = command[3];
                        people[command[0]].Parents.Add(parent);
                        break;
                    case "children":
                        Children child = new Children();
                        child.Name = command[2];
                        child.BDay = command[3];
                        people[command[0]].Children.Add(child);
                        break;
                    case "car":
                        Car car = new Car();
                        car.Model = command[2];
                        car.Speed = double.Parse(command[3]);
                        people[command[0]].Car = car;
                        break;
                }       
            }
            string name = Console.ReadLine();
            Console.Write("\n" + people[name].ToString());
        }
    }
}
