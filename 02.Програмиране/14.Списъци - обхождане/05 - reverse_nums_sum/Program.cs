using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_nums_sum {
    class Program {
        static void Main(string[] args) {
            /*List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                string[] s  = nums.Select(i => string.Join("",i.ToString().Reverse())).ToArray();
                Console.WriteLine(s.Select(int.Parse).ToList().Sum());*/
            /*List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < nums.Count; i++) {
                int reverse = 0;
                while (nums[i] > 0){
                    reverse = reverse * 10 + nums[i] % 10;
                    nums[i] /= 10;
                }
                sum += reverse;
            }
            Console.WriteLine(sum);*/
            Console.WriteLine(Console.ReadLine().Split(' ').Select(i => string.Join("", i.ToString().Reverse())).Select(int.Parse).ToList().Sum());
        }
    }
}
