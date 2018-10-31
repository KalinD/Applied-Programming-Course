using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporting_freight {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, Truck> trucks = new Dictionary<string, Truck>();
            Dictionary<string, Freight> freights = new Dictionary<string, Freight>();
            List<string> input1 = Console.ReadLine().Split('=', ';').Where(x => x != "").ToList();
            List<string> input2 = Console.ReadLine().Split('=', ';').Where(x => x != "").ToList();
            
            for(int i = 0; i < input1.Count; i++){
                try{
                    string name = input1[i++];
                    double capacity = double.Parse(input1[i]);
                    Truck truck = new Truck(name, capacity);
                    trucks.Add(name, truck);
                }
                catch(ArgumentException e){
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(input2.Count);
            for (int i = 0; i < input2.Count; i++) {
                try {
                    string name = input2[i++];
                    double weight = double.Parse(input2[i]);
                    Freight freight = new Freight(name, weight);
                    freights.Add(name, freight);
                }
                catch (ArgumentException e) {
                    Console.WriteLine(e.Message);
                }
            }

            while(true){
                List<string> command = Console.ReadLine().Split().ToList();
                if(command[0] == "END"){
                    break;
                }
                if(trucks[command[0]].Capacity >= freights[command[1]].Weight){
                    trucks[command[0]].Capacity -= freights[command[1]].Weight;
                    trucks[command[0]].Freights.Add(freights[command[1]]);
                    Console.WriteLine($"{command[0]} loaded {command[1]}");
                }
                else{
                    Console.WriteLine($"{command[0]} can not load {command[1]}");
                }
            }
            Console.WriteLine();
            foreach(var truck in trucks){
                Console.WriteLine($"{truck.Key} - {truck.Value.ToString()}");
            }
        }
    }
}


