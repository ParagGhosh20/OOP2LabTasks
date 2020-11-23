using System;
using System.Collections.Generic;
using System.Text;

namespace AccountFinal
{
    class Savings : Account
    {
        public int TransCount { get; set; }

      
        public int TransNo { get; set; }


        public Savings() { }
        

        public Savings(string aName, string aNo, double balance, int transNo) : base(aName, aNo, balance)
        {
            this.TransNo = transNo;
        }

        public override void Withdraw(double amount)
        {
            TransCount++;
            if (TransCount <= TransNo && Balance - amount >= 500)
            {
                Balance -= amount;
                Console.WriteLine("SA withdraw successfull");
            }
            else
            {
                if (TransCount > TransNo)
                {
                    Console.WriteLine("Min transaction reached");
                }

                else
                    Console.WriteLine("not enoug Balance");
            }

        }

    }
}
