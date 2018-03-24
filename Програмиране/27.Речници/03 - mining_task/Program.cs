using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mining_task {
    class Program {
        static void Main(string[] args){
            Dictionary<string, int> mine = new Dictionary<string, int>();
            while(true){
                string resource = Console.ReadLine();
                if(resource == "stop"){
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if(mine.ContainsKey(resource)){
                    mine[resource] += quantity;
                    continue;
                }
                mine[resource] = quantity;
            }
            foreach(var rock in mine){
                Console.WriteLine($"{rock.Key} -> {rock.Value}");
            }
        }
    }
}
