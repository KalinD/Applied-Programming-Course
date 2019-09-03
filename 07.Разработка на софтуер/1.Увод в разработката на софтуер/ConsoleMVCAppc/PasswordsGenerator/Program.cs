using PasswordsGenerator.Controllers;
using System;

namespace PasswordsGenerator {
    class Program {
        static void Main(string[] args) {
            Controller controller = new Controller();
            controller.Start();
        }
    }
}
