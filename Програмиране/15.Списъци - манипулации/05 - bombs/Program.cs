using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bombs {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while(nums.Contains(bomb[0])){
                int index = nums.IndexOf(bomb[0]);
                int j = 0;
                for (int i = index - bomb[1] >= 0 ? index - bomb[1] : 0; j < bomb[1] * 2 + 1 && i < nums.Count; i++){
                    nums.RemoveAt(i);
                    i--;
                    j++;
                }
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
