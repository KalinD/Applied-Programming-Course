using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_tree {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            string input = Console.ReadLine();
            List<string> commands = new List<string>();
            Person mainPerson;
            try {
                mainPerson = new Person(DateTime.Parse(input));
            }
            catch (Exception) {
                mainPerson = new Person(input);
            }
            while (true) {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "End") {
                    break;
                }
                if (command.Contains("-")) {
                    commands.Add(string.Join(" ", command));
                }
                else {
                    Person p = new Person($"{command[0]} {command[1]}", DateTime.Parse(command[2]));
                    if (input == command[2]) {
                        input = $"{command[0]} {command[1]}";
                    }
                    people.Add(p.Name, p);
                }
            }
            foreach (var com in commands) {
                List<string> command = com.Split().ToList();
                command.Remove("-");
                Person p1;
                try {
                    p1 = new Person(DateTime.Parse(command[0]));
                }
                catch (Exception) {
                    p1 = new Person($"{command[0]} {command[1]}");
                }
                Person p2;
                try {
                    if (p1.Name != null) {
                        p2 = new Person(DateTime.Parse(command[2]));
                    }
                    else {
                        p2 = new Person(DateTime.Parse(command[1]));
                    }
                }
                catch (Exception) {
                    if (p1.Name != null) {
                        p2 = new Person($"{command[2]} {command[3]}");
                    }
                    else {
                        p2 = new Person($"{command[1]} {command[2]}");
                    }
                }
                if(p1.Name != null){
                    if(p2.Name != null){
                        people[p1.Name].Children.Add(people[p2.Name]);
                        people[p2.Name].Parents.Add(people[p1.Name]);
                    }
                    else{
                        string name = null;
                        foreach(var person in people){
                            if(person.Value.BDate == p2.BDate){
                                name = person.Value.Name;
                                break;
                            }
                        }
                        people[p1.Name].Children.Add(people[name]);
                        people[name].Parents.Add(people[p1.Name]);
                    }
                }
                else{
                    string name1 = null;
                    foreach (var person in people) {
                        if (person.Value.BDate == p1.BDate) {
                            name1 = person.Value.Name;
                            break;
                        }
                    }
                    if (p2.Name != null) {
                        people[name1].Children.Add(people[p2.Name]);
                        people[p2.Name].Parents.Add(people[name1]);
                    }
                    else {
                        string name2 = null;
                        foreach (var person in people) {
                            if (person.Value.BDate == p2.BDate) {
                                name2 = person.Value.Name;
                                break;
                            }
                        }
                        people[name1].Children.Add(people[name2]);
                        people[name2].Parents.Add(people[name1]);
                    }
                }
            }
            Console.WriteLine($"\n{input} {people[input].BDate.ToString("d\\/M\\/yyyy")} \nParents:");
            foreach (var person in people[input].Parents) {
                Console.WriteLine(person.Name + " " + person.BDate.ToString("d\\/M\\/yyyy"));
            }
            Console.WriteLine("Children:");
            foreach (var person in people[input].Children) {
                Console.WriteLine(person.Name + " " + person.BDate.ToString("d\\/M\\/yyyy"));
            }
        }
    }
}
