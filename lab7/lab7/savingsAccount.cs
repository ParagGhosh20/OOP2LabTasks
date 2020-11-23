using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class SavingsAccount : Account
    {
        public SavingsAccount() { }
        public SavingsAccount(string accNo, string accName, double balance) : base(accNo, accName, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if (balance - amount >= 500)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }
    }
}
