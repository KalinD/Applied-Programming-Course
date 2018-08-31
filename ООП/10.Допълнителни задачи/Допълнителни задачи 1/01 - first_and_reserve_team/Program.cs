using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_and_reserve_team {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Team team = new Team("FitzSimmons");
            for(int i = 0; i < n; i++){
                List<string> input = Console.ReadLine().Split().ToList();
                try{
                    Person person = new Person(input[0], input[1], int.Parse(input[2]), double.Parse(input[3]));
                    team.AddPlayer(person);
                }
                catch(ArgumentException e){
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"First team has {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");
        }
    }
}
