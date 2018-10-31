using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_a_football_team {
    class Person {
        private string name;
        private int rating;
        private int endurance;
        private int sprint;
        private int drible;
        private int passes;
        private int shoot;

        public int Rating => rating;

        public string Name{
            get => name;
            set{
                if (value == null || value.Trim() == null) {
                    Console.WriteLine("A name should not be empty.");
                }
                name = value;
            }
        }

        public int Endurance{
            get => endurance;
            set{
                if(value < 0 || value > 100){
                    throw new ArgumentException("Endurance should be between 0 and 100");
                }
                endurance = value;
                rating = (endurance + sprint + drible + passes + shoot) / 5;
            }
        }

        public int Sprint {
            get => sprint;
            set {
                if (value < 0 || value > 100) {
                    throw new ArgumentException("Sprint should be between 0 and 100");
                }
                sprint = value;
                rating = (endurance + sprint + drible + passes + shoot) / 5;
            }
        }

        public int Drible {
            get => drible;
            set {
                if (value < 0 || value > 100) {
                    throw new ArgumentException("Drible should be between 0 and 100");
                }
                drible = value;
                rating = (endurance + sprint + drible + passes + shoot) / 5;
            }
        }

        public int Passes {
            get => passes;
            set {
                if (value < 0 || value > 100) {
                    throw new ArgumentException("Passes should be between 0 and 100");
                }
                passes = value;
                rating = (endurance + sprint + drible + passes + shoot) / 5;
            }
        }

        public int Shoot {
            get => shoot;
            set {
                if (value < 0 || value > 100) {
                    throw new ArgumentException("Shoot should be between 0 and 100");
                }
                shoot = value;
                rating = (endurance + sprint + drible + passes + shoot) / 5;
            }
        }

        public Person(string name, int endurance, int sprint, int drible, int passes, int shoot){
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Drible = drible;
            Passes = passes;
            Shoot = shoot;
        }
    }
}

