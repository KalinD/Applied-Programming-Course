using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove_last_number {
    class Program {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            num.RemoveAll(x=>x==num[num.Count - 1]);
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
