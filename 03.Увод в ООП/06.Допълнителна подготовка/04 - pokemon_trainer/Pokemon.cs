using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_trainer {
    class Pokemon {
        //име, елемент и здраве
        private string name;
        private string element;
        private int hp;

        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public string Element {
            get {
                return element;
            }
            set {
                element = value;
            }
        }

        public int HP {
            get {
                return hp;
            }
            set {
                hp = value;
            }
        }
    }
}
