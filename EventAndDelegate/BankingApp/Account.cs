using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Account
    {
        public event Operations overBalance;

        public event Operations underBalance;
        public double balance {  get; set; }

        public void withdraw(double amount)
        {
            double tempamount = balance - amount;
            monitor(tempamount);
            balance = tempamount;
        }

        public void deposite(double amount)
        {
            double tempamount = balance + amount;
            monitor(tempamount);
            balance = tempamount;
        }

        public void monitor(double amount)
        {
            if (amount < 10000)
            {
                underBalance();
            }
            if (amount > 250000)
            {
                overBalance();
            }
        }
    }
}
