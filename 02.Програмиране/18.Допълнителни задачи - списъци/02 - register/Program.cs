using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register {
    class Program {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[] {' ', ':', ',', ';', '.', '(', ')', '\\', '\'', '!', '"', '/', '[', ']'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerWords = new List<string>();
            List<string> upperWords = new List<string>();
            List<string> mixWords = new List<string>();
            
            foreach(string word in words){
                bool isLower = true;
                if(word.ToLower() == word){
                    for(int i = 0 ; i < word.Length; i++){
                        if(!char.IsLetter(word[i])){
                            mixWords.Add(word);
                            isLower = false;
                            break;
                        }
                    }
                    if(isLower){
                        lowerWords.Add(word);
                    }
                }
                
                else if(word.ToUpper() == word)
                {
                    bool isUpper = true;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (!char.IsLetter(word[i]))
                        {
                            mixWords.Add(word);
                            isUpper = false;
                            break;
                        }
                    }
                    if(isUpper){
                        upperWords.Add(word);
                    }
                }
                else{
                    mixWords.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperWords)}");
        }
    }
}
