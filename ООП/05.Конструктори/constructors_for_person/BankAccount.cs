using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors_for_person {
    class BankAccount {
        private string id;
        private double amount;

        public string ID{
            get;
            set;
        }
        public double Amount{
            get{
                return amount;
            }
            set{
                amount = value;
            }
        }

        public BankAccount(string id, double amount){
            this.id = id;
            this.amount = amount;
        }
    }
}
