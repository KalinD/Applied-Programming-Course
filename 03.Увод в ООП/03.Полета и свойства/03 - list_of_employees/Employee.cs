using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_of_employees {
    class Employee {
        private string name; //
        private double salary; //
        private string rank; //
        private string department; //
        private string email;
        private int age;
        public string Name {
            get;
            set;
        }
        public double Salary {
            get;
            set;
        }
        public string Rank {
            get;
            set;
        }
        public string Department {
            get;
            set;
        }
        public string Email {
            get;
            set;
        }
        public int Age {
            get;
            set;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name).Append(" ").Append($"{Salary:F2}").Append(" ");
            if(Email == null){
                sb.Append("n/a").Append(" ");
            }
            else{
                sb.Append(Email).Append(" ");
            }
            if (Age == 0) {
                sb.Append("-1").Append(" ");
            }
            else {
                sb.Append(Age).Append(" ");
            }
            return sb.ToString();
        }
    }
}
