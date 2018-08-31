using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_wars {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, Planet> planets = new Dictionary<string, Planet>();
            Dictionary<string, Building> buildings = new Dictionary<string, Building>();
            Dictionary<string, Ship> ships = new Dictionary<string, Ship>();

            List<string> input = Console.ReadLine().Split().ToList();
            for(int i = 0; i < input.Count; i += 3){
                try{
                    Planet planet = new Planet(input[i], double.Parse(input[i + 1]), double.Parse(input[i + 2]));
                    planets.Add(input[i], planet);
                }
                catch (ArgumentException e) {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine();
            input = Console.ReadLine().Split().ToList();
            for (int i = 0; i < input.Count; i += 3) {
                try{
                    Building building = new Building(input[i], double.Parse(input[i + 1]), double.Parse(input[i + 2]));
                    buildings.Add(input[i], building);
                }
                catch (ArgumentException e) {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine();
            input = Console.ReadLine().Split().ToList();
            for (int i = 0; i < input.Count; i += 3) {
                try{
                    Ship ship = new Ship(input[i], double.Parse(input[i + 1]), double.Parse(input[i + 2]));
                    ships.Add(input[i], ship);
                }
                catch(ArgumentException e){
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine();
            while(!false){
                List<string> command = Console.ReadLine().Split().Where(x => x != "").ToList();
                if(command[0] == "END"){
                    break;
                }
                if(command[0] == "TIME"){
                    foreach(var planet in planets){
                        planet.Value.Metal += planet.Value.Buildings[0] * 100 * int.Parse(command[1]);
                        planet.Value.Mineral += planet.Value.Buildings[1] * 100 * int.Parse(command[1]);
                    }
                }
                else if(command.Count == 2){
                    planets[command[0]].BuyBuilding(buildings[command[1]]);
                }
                else {
                    planets[command[0]].BuyShip(ships[command[1]], int.Parse(command[2]));
                }
            }
            Console.WriteLine("\nResources:");
            foreach(var planet in planets){
                Console.WriteLine($"{planet.Key} {planet.Value.Metal} {planet.Value.Mineral}");
            }

            Console.WriteLine("\nBuildings:");
            foreach (var planet in planets) {
                if(planet.Value.HasBuildings){
                    Console.WriteLine($"{planet.Key} MetalMine {planet.Value.Buildings[0]} MineralMine {planet.Value.Buildings[1]} ShipYard {planet.Value.Buildings[2]}");
                }
                else{
                    Console.WriteLine($"On {planet.Key} there are no buildings");
                }
            }
            Console.WriteLine("\nShips:");
            foreach (var planet in planets) {
                if(planet.Value.HasShips){
                    Console.WriteLine($"{planet.Key} Transporter {planet.Value.Ships[0]} BattleShip {planet.Value.Ships[1]} Fighter {planet.Value.Ships[2]}");
                }
                else{
                    Console.WriteLine($"On {planet.Key} there are no ships");
                }
            }
        }
    }
}
