using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BankingCashConuter");
            BankAccount account;
            LinkedList<BankAccount> accountList = new LinkedList<BankAccount>();
            CashCounter cashCounter = new CashCounter();
            // CashCounterQueue<BankAccount> cashCounterQueue = new CashCounterQueue<BankAccount>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter account holder name:");
                string name = Console.ReadLine();
                Console.WriteLine("enter amount:");
                int amount = Convert.ToInt32(Console.ReadLine());
                account = new BankAccount(name, amount);
                accountList.AddLast(account);
                cashCounter.SelectChoice(accountList);
            }


            foreach (BankAccount i in accountList)
            {
                Console.WriteLine("Account holder:{0}   balance:{1}", i.accHolderName, i.amount);
            }
        }
    }
}


