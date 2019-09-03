using PoolPipes.Models;
using PoolPipes.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoolPipes.Controllers {
    class Controller {
        private Display display;
        private Pool pool;

        internal Display Display { get => display; set => display = value; }
        internal Pool Pool { get => pool; set => pool = value; }

        public Controller() {
           Display = new Display();
            Pool = new Pool();
        }

        public void Start() {
            pool.Volume = display.Volume;
            pool.AddPipe(new Pipe(display.Pipe1));
            pool.AddPipe(new Pipe(display.Pipe2));

            display.PrintResult(pool.ReturnResult(display.Hours));
        }
    }
}
