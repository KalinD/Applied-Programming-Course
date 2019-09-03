using PasswordsGenerator.Models;
using PasswordsGenerator.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordsGenerator.Controllers {
    class Controller {
        private Generator generator;
        private Display display;

        internal Generator Generator { get => generator; set => generator = value; }
        internal Display Display { get => display; set => display = value; }

        public Controller() {
            Generator = new Generator();
            Display = new Display();
        }

        public void Start() {
            Generator.MaxLetter = Display.MaxLetter;
            Generator.MaxNum = Display.MaxNum;

            Generator.GeneratePasswords();

            Display.ResultPasswords = Generator.Passwords;

            Display.PrintResult();
        }
    }
}
