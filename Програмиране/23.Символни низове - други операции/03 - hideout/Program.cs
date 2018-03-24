using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hideout {
    class Program {
        static void Main(string[] args) {
            string hideout = Console.ReadLine();
            while (true) {
                int removed = 0;
                string hideoutCopy = hideout;
                List<string> toSearch = Console.ReadLine().Split(' ').ToList();
                //toSearch[0] = symbol; toSearch[1] = count;
                int count = 0;
                while (hideoutCopy.Contains(toSearch[0])) {
                    int index = hideoutCopy.IndexOf(toSearch[0]);
                    count = 0;
                    for (int i = index; hideoutCopy[index] == hideoutCopy[i]; i++){
                        count++;
                    }
                    if(count >= int.Parse(toSearch[1])){
                        Console.WriteLine($"Hideout found at index {index + removed} and it is with size {count}!");
                        break;
                    }
                    else{
                        hideoutCopy = hideoutCopy.Remove(index, count);
                        removed += count;
                    }
                }
                if (count >= int.Parse(toSearch[1])) {
                    break;
                }
            }
        }
    }
}
