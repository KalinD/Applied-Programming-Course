using PoolPipes.Controllers;
using System;

namespace PoolPipes {
    class Program {
        static void Main(string[] args) {
            Controller controller = new Controller();
            controller.Start();
        }
    }
}
