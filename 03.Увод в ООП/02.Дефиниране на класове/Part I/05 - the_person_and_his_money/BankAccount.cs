using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_person_and_his_money {
    class BankAccount {
        private int id;
        private double balance;
        public int ID{
            get{
                return id;
            }
            set{
                id = value;
            }
        }
        public double Balance {
            get {
                return balance;
            }
            set {
                balance = value;
            }
        }
    }
}
