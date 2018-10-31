using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace better_phone_dictionary {
    class Program {
        static void Main(string[] args) {
            SortedDictionary<string, string> phones = new SortedDictionary<string, string>();
            while(true){
                List<string> data = Console.ReadLine().Split(' ').ToList();
                if(data[0] == "END"){
                    break;
                }
                if(data[0] == "A"){
                    phones[data[1]] = data[2];
                }
                if(data[0] == "ListAll"){
                    foreach(var number in phones){
                        Console.WriteLine($"{number.Key} -> {number.Value}");
                    }
                }
            }
        }
    }
}
