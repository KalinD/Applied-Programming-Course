using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace only_letters {
    class Program {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = 0;
            int index = -1;
            for(int i = 0; i < word.Length; i++){
                if(word[i] >= '0' && word[i] <= '9'){
                    count++;
                    if(index == -1){
                        index = i;
                    }
                }
                else{
                    if(count > 0){
                        string letter = word[i].ToString();
                        word = word.Remove(index, count);
                        word = word.Insert(index, letter);
                        count = 0;
                        index = -1;
                    }
                }
            }
            Console.WriteLine(word);
        }
    }
}
