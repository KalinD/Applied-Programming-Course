using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_dictionary {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, string> phones = new Dictionary<string, string>();
            while(true){
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if(input[0] == "END"){
                    break;
                }
                if(input[0] == "A"){
                    phones[input[1]] = input[2];
                }
                if(input[0] == "S"){
                    if(phones.ContainsKey(input[1])){
                        string number;
                        phones.TryGetValue(input[1], out number);
                        Console.WriteLine($"{input[1]} -> {number}");
                    }
                    else{
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }
                }
            }
        }
    }
}
