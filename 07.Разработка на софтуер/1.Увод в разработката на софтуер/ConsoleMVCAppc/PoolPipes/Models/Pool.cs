using System;
using System.Collections.Generic;
using System.Text;

namespace PoolPipes.Models {
    class Pool {
        private double volume;
        private List<Pipe> pipes;

        public double Volume { get => volume; set => volume = value; }
        internal List<Pipe> Pipes { get => pipes; set => pipes = value; }

        public Pool() {
            Pipes = new List<Pipe>();
        }
        public string ReturnResult(double hours) {
            double litters = 0;
            double pipe1Litters = Pipes[0].CalculateDispensedWater(hours);
            double pipe2Litters = Pipes[1].CalculateDispensedWater(hours);
            foreach(Pipe pipe in Pipes) {
                litters += pipe.CalculateDispensedWater(hours);
            }

            if(Volume - litters < 0) {
                return $"For {hours} hours the pool overflows with {litters - Volume} liters.";
            }
            else {
                return $"The pool is {(int)((litters / Volume) * 100)}% full. Pipe 1: {(int)((pipe1Litters / litters) * 100)}%. Pipe 2: {(int)((pipe2Litters / litters) * 100)}%.";
            }
        }

        public void AddPipe(Pipe pipe) {
            Pipes.Add(pipe);
        }
    }
}
