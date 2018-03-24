using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insert_element_in_sorted_array {
    class Program {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int toAdd = int.Parse(Console.ReadLine());
            int[] arr = new int[nums.Length + 1];
            int r = 0, l = nums.Length - 1, m;
            m = (l + r) / 2;
            while (r + 1 != l){
                m = (l + r) / 2;
                if (nums[m] < toAdd){
                    r = m;
                }
                else{
                    l = m;
                }
            }
            int i = nums.Length;
            for(i = nums.Length; i > m; i--){
                arr[i] = nums[i - 1];
            }
            arr[i] = toAdd;
            for(i = 0; i < m; i++){
                arr[i] = nums[i];
            }
            nums = arr;
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
