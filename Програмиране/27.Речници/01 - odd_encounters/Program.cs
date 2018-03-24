using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_encounters {
    class Program {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach(string word in input){
                if(!dic.ContainsKey(word)){
                    dic[word] = 0;
                }
                dic[word]++;
            }
            List<string> result = new List<string>();
            foreach(var item in dic){
                if(item.Value % 2 != 0){
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
