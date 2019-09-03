using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordsGenerator.Models {
    class Generator {
        private List<string> passwords;
        private int maxNum;
        private int maxLetter;

        public int MaxNum { get => maxNum; set => maxNum = value; }
        public int MaxLetter { get => maxLetter; set => maxLetter = value; }
        public List<string> Passwords { get => passwords; set => passwords = value; }

        public Generator() {
            Passwords = new List<string>();
        }

        public void GeneratePasswords() {
            for(int i = 1; i <= maxNum; i++) {
                for(int j = 1; j <= maxNum; j++) {
                    for(char k = 'a'; k < 'a' + MaxLetter; k++) {
                        for(char l = 'a'; l < 'a' + MaxLetter; l++) {
                            for(int m = Math.Max(i, j) + 1; m <= maxNum; m++) {
                                Passwords.Add($"{i}{j}{k}{l}{m}");
                            }
                        }
                    }
                }
            }
        }
    }
}
