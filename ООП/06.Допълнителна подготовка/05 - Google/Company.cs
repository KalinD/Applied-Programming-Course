using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google {
    class Company {
        //<имеНаФирма> <отдел> <заплата>
        private string name;
        private string department;
        private double payment;

        public string Name{
            get => name;
            set => name = value;
        }

        public string Department {
            get => department;
            set => department = value;
        }

        public double Payment {
            get => payment;
            set => payment = value;
        }

        public override string ToString() {
            if(name != null){
                return $"Company:\n{name} {department} {payment:f2}\n";
            }
            return "Company:\n";
        }
    }
}
