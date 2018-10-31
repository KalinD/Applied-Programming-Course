using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changing_list {
    class Program {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            while(commands[0] != "Odd" && commands[0] != "Even"){
                if(commands[0] == "Delete"){
                    nums.RemoveAll(x => x == int.Parse(commands[1]));
                }
                else if(commands[0] == "Insert"){
                    nums.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
            if(commands[0] == "Odd"){
                foreach(int num in nums){
                    if(num % 2 != 0){
                        Console.Write(num + " ");
                    }
                }
            }
            else{
                foreach (int num in nums){
                    if (num % 2 == 0){
                        Console.Write(num + " ");
                    }
                }
            }
        }
    }
}
