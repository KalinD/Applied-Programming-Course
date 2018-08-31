using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_trainer {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while(true){
                List<string> command = Console.ReadLine().Split().ToList();
                if(command[0] == "Tournament"){
                    break;
                }
                Trainer trainer = new Trainer();
                Pokemon pokemon = new Pokemon();
                if(!trainers.ContainsKey(command[0])){
                    trainers[command[0]] = new Trainer();
                }
                trainers[command[0]].Name = command[0];
                pokemon.Name = command[1];
                pokemon.Element = command[2];
                pokemon.HP = int.Parse(command[3]);
                trainers[command[0]].PokemonCollection.Add(pokemon);
            }
            while (true) {
                string command = Console.ReadLine();
                if (command == "End") {
                    break;
                }
                foreach(var trainer in trainers){
                    int startBadgeAmount = trainer.Value.BadgesAmoount;
                    foreach(Pokemon pokemon in trainer.Value.PokemonCollection){
                        if(pokemon.Element == command){
                            trainer.Value.BadgesAmoount++;
                        }
                    }
                    if(startBadgeAmount == trainer.Value.BadgesAmoount){
                        for(int i = 0; i < trainer.Value.PokemonCollection.Count; i++){
                            trainer.Value.PokemonCollection[i].HP -= 10;
                            if(trainer.Value.PokemonCollection[i].HP <= 0){
                                trainer.Value.PokemonCollection.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }
            foreach(var trainer in trainers.OrderByDescending(x => x.Value.BadgesAmoount)){
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.BadgesAmoount} {trainer.Value.PokemonCollection.Count}");
            }
        }
    }
}
