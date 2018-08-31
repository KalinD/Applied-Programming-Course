using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_a_football_team {
    class Team {
        private string name;
        private List<Person> players;
        private int rating;

        public string Name {
            get => name;
            set {
                if (value == null || value.Trim() == null) {
                    Console.WriteLine("A name should not be empty.");
                }
                name = value;
            }
        }

        public double Rating => rating;

        public IReadOnlyCollection<Person> Players {
            get => players.AsReadOnly();
        }

        public Team(string name) {
            Name = name;
            players = new List<Person>();
        }

        public void AddPlayer(Person person) {
            players.Add(person);
            rating = 0;
            foreach (var player in players){
                rating += player.Rating;
            }
            rating /= players.Count;
        }

        public void RemovePlayer(string name){
            for(int i = 0; i < players.Count; i++){
                if(players[i].Name == name){
                    players.Remove(players[i]);
                }
            }
        }
    }
}
