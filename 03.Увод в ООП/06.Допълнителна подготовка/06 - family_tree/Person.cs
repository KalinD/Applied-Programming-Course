using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_tree {
    class Person {
        private string name;
        private DateTime bDate;
        private List<Person> parents;
        private List<Person> children;

        public string Name{
            get => name;
            set => name = value;
        }

        public DateTime BDate{
            get => bDate;
            set => bDate = value;
        }

        public List<Person> Parents{
            get => parents;
            set => parents = value;
        }

        public List<Person> Children {
            get => children;
            set => children = value;
        }

        public Person(string name, DateTime date){
            this.name = name;
            bDate = date;
            parents = new List<Person>();
            children = new List<Person>();
        }

        public Person(string name) : this(name, new DateTime()){ }

        public Person(DateTime date) : this(null, date) { }

        public Person() : this(null, new DateTime()){ }
    }
}
