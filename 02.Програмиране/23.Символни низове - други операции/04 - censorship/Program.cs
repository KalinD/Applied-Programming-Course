using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace censorship {
    class Program {
        static void Main(string[] args) {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();
            while(sentence.Contains(word)){
                int index = sentence.IndexOf(word);
                sentence = sentence.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(sentence);
        }
    }
}
