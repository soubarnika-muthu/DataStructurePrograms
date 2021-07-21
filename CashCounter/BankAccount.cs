using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    public class BankAccount
    {
        public string accHolderName;
        public int amount;
        public BankAccount(string accHolderName, int amount)
        {
            this.accHolderName = accHolderName;
            this.amount = amount;
        }
      
    }
}
