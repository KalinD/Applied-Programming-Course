using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_a_football_team {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            while(true){
                List<string> command = Console.ReadLine().Split(';').ToList();
                if(command[0] == "END"){
                    break;
                }
                switch(command[0]){
                    case "Team":
                        Team team = new Team(command[1]);
                        teams.Add(command[1], team);
                        break;
                    case "Add":
                        try{
                            Person person = new Person(command[2], int.Parse(command[3]), int.Parse(command[4]), int.Parse(command[5]), int.Parse(command[6]), int.Parse(command[7]));
                            if(!teams.ContainsKey(command[1])){
                                Console.WriteLine($"Team {command[1]}  does not exists.");
                                break;
                            }
                            teams[command[1]].AddPlayer(person);
                        }
                        catch(ArgumentException e){
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Remove":
                        if(!teams.ContainsKey(command[2])){
                            Console.WriteLine($"Player {command[2]} is not in {command[1]} team.");
                        }
                        else{
                            teams[command[1]].RemovePlayer(command[2]);
                        }
                        break;
                    case "Rating":
                        if (!teams.ContainsKey(command[1])) {
                            Console.WriteLine($"Team {command[1]}  does not exists.");
                            break;
                        }
                        Console.WriteLine($"{teams[command[1]].Name} - {teams[command[1]].Rating}");
                        break;
                }
            }
        }
    }
}
