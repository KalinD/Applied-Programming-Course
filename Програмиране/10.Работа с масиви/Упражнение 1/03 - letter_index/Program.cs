﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_index {
    class Program {
        static void Main(string[] args){
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++){
                Console.WriteLine($"{word[i]} -> {word[i] - 'a'}");
            }
        }
    }
}
