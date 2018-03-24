using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_increasing_sequence {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> len = new List<int>();
            List<int> result = new List<int>();
            List<int> prev = new List<int>();
            for (int i = 0; i < nums.Count; i++){
                int left = -1;
                for(int j = 0; j < i; j++){
                    if(nums[j] < nums[i]){
                        left = j;
                    }
                }
                prev.Add(left);
                if(left >= 0){
                    len.Add(1 + len[left]);
                }
                else{
                    len.Add(1);
                }
            }
            int index = len.IndexOf(len.Max());
            while (true){
                result.Add(nums[index]);
                index = prev[index];
                if(index == -1){
                    break;
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
