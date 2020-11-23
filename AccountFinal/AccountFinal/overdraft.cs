using System;
using System.Collections.Generic;
using System.Text;

namespace AccountFinal
{
    class Overdraft : Account
    {
        public double OdLimit { get; set; }





        public Overdraft()
        {

        }

        public Overdraft(string aName, string aNo, double balance, double odLimit) : base(aName, aNo, balance)
        {
            this.OdLimit = odLimit;
        }

        public override void Withdraw(double amount)
        {

            if (amount <= Balance + OdLimit)
            {
                Balance -= amount;
                Console.WriteLine(" withdraw successfull");
            }
            else
                Console.WriteLine(" Limit crossed");

        }

    }
}
