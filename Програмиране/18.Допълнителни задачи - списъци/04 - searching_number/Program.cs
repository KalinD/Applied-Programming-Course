using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searching_number {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> toFind = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.RemoveRange(toFind[0], nums.Count - toFind[0]);
            nums.RemoveRange(0, toFind[1]);
            if (nums.Contains(toFind[2])) {
                Console.WriteLine("YES!");
            }
            else{
                Console.WriteLine("NO!");
            }
        }
    }
}
