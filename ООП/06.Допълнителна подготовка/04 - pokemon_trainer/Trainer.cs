using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_trainer {
    class Trainer {
        //име, брой значки и колекция от покемони
        private string name;
        private int badgesAmount;
        private List<Pokemon> pokemon;

        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public int BadgesAmoount {
            get {
                return badgesAmount;
            }
            set {
                badgesAmount = value;
            }
        }

        public List<Pokemon> PokemonCollection {
            get {
                return pokemon;
            }
            set {
                pokemon = value;
            }
        }
        
        public Trainer(string name, int badges, List<Pokemon> pokemon){
            this.name = name;
            BadgesAmoount = badges;
            this.pokemon = pokemon;
        }
        public Trainer() : this(null, 0, new List<Pokemon>()){
        }
    }
}
