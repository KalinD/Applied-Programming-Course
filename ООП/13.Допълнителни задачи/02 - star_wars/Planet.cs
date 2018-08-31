using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_wars {
    class Planet {
        string name;
        double metal;
        double mineral;
        int[] buildings;
        int[] ships;
        bool hasBuildings;
        bool hasShips;

        public string Name {
            get => name;
            set {
                if(value == ""){
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public double Metal {
            get => metal;
            set {
                if (value < 0) {
                    throw new ArgumentException("Amount cannot be negative");
                }
                metal = value;
            }
        }

        public double Mineral {
            get => mineral;
            set {
                if (value < 0) {
                    Console.WriteLine(value + " " + mineral);
                    throw new ArgumentException("Amount cannot be negative");
                }
                mineral = value;
            }
        }

        public int[] Buildings => buildings;
        public int[] Ships => ships;

        public Planet(string name, double metal, double mineral){
            Name = name;
            Metal = metal;
            Mineral = mineral;
            buildings = new int[3];
            ships = new int[3];
            hasBuildings = false;
            hasShips = false;
        }

        public bool HasShips => hasShips;
        public bool HasBuildings => hasBuildings;

        public void BuyShip(Ship ship, int amount){
            int index = 0;
            switch (ship.Name) {
                case "Transporter":
                    index = 0;
                    break;
                case "BattleShip":
                    index = 1;
                    break;
                case "Fighter ":
                    index = 2;
                    break;
            }
            if(Metal >= ship.Metal * amount && Mineral >= ship.Mineral * amount){
                Console.WriteLine($"On {Name} was builded {ship.Name} {amount}");
                Metal -= ship.Metal * amount;
                Mineral -= ship.Mineral * amount;
                ships[index] += amount;
                hasShips = true;
            }
            else{
                Console.WriteLine($"On {Name} can not to build {ship.Name} {amount} units");
            }
        }

        public void BuyBuilding(Building building){
            int index = 0;
            switch (building.Name) {
                case "MetalMine":
                index = 0;
                break;
                case "MineralMine":
                index = 1;
                break;
                case "ShipYard":
                index = 2;
                break;
            }
            if (Metal >= building.Metal && Mineral >= building.Mineral){
                buildings[index]++;
                Metal -= building.Metal;
                Mineral -= building.Mineral;
                Console.WriteLine($"On {Name} was builded {building.Name}");
                hasBuildings = true;
            }
            else{
                string type = Metal >= building.Metal ? "Mineral" : "Meta";
                Console.WriteLine($"{type} on {Name} not enough to build a {building.Name} ");
            }
        }
    }
}
