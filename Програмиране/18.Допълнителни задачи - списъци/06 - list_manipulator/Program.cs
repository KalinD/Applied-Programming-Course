using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_manipulator {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true) {
                List<string> commands = Console.ReadLine().Split(' ').ToList();
                switch (commands[0]) {
                    case "add":
                        //index, element
                        nums.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                    case "addMany":
                        //index, elements
                        nums.InsertRange(int.Parse(commands[1]), commands.Skip(2).Select(int.Parse));
                        break;
                    case "contains":
                        //element
                        Console.WriteLine(nums.IndexOf(int.Parse(commands[1])));
                        break;
                    case "remove":
                        //index
                        nums.RemoveAt(int.Parse(commands[1]));
                        break;
                    case "shift":
                        int temp = nums[0];
                        for (int i = 0; i < nums.Count - 1; i++) {
                            nums[i] = nums[i + 1];
                        }
                        nums[nums.Count - 1] = temp;
                        break;
                    case "sumPairs":
                        for (int i = 0; i < nums.Count; i++) {
                            int sum = nums[i] + nums[i + 1];
                            nums.RemoveAt(i);
                            nums.RemoveAt(i);
                            nums.Insert(i, sum);
                        }
                        break;
                    case "print":
                        Console.WriteLine($"[{string.Join(", ", nums)}]");
                        break;
                }
                if (commands[0] == "print") {
                    break;
                }
            }
        }
    }
}
