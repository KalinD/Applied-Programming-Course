using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_bankAccount_class {
    class BankAccount {
        private int id;
        private double balance;
        public double Balance{
            get{
                return balance;
            }
            set{
                balance = value;
            }
        }
        public int ID {
            get {
                return id;
            }
            set {
                id = value;
            }
        }
    }
}
