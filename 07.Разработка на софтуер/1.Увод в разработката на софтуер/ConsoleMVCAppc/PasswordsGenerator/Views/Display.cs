using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordsGenerator.Views {
    class Display {
        private int maxNum;
        private int maxLetter;
        private List<string> resultPasswords;

        public int MaxNum { get => maxNum; set => maxNum = value; }
        public int MaxLetter { get => maxLetter; set => maxLetter = value; }
        public List<string> ResultPasswords { get => resultPasswords; set => resultPasswords = value; }

        public Display() {
            ResultPasswords = new List<string>();
            GetValues();
        }

        private void GetValues() {
            MaxNum = int.Parse(Console.ReadLine());
            MaxLetter = int.Parse(Console.ReadLine());
        }

        public void PrintResult() {
            Console.WriteLine(string.Join(" ", ResultPasswords));
        }
    }
}
