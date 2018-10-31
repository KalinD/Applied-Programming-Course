using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google {
    class Person {
        private string name;
        private Company company;
        private Car car;
        private List<Children> children;
        private List<Parents> parents;
        private List<Pokemon> pokemon;

        public string Name{
            get => name;
            set => name = value;
        }

        public Car Car {
            get => car;
            set => car = value;
        }

        public Company CompanyType {
            get => company;
            set => company = value;
        }

        public List<Children> Children{
            get => children;
            set => children = value;
        }

        public List<Parents> Parents{
            get => parents;
            set => parents = value;
        }

        public List<Pokemon> Pokemon{
            get => pokemon;
            set => pokemon = value;
        }

        public Person(){
            car = new Car();
            company = new Company();
            children = new List<Children>();
            parents = new List<Parents>();
            pokemon = new List<Pokemon>();
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(name + "\n" + company.ToString() + car.ToString() + "Pokemon:\n");
            foreach(Pokemon monster in pokemon){
                sb.Append(monster.ToString());
            }
            sb.Append("Parents:\n");
            foreach (Parents parent in parents) {
                sb.Append(parent.ToString());
            }
            sb.Append("Children:\n");
            foreach (Children child in children) {
                sb.Append(child.ToString());
            }
            return sb.ToString();
        }
    }
}
