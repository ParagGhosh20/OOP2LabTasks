using System;
using System.Collections.Generic;
using System.Text;

namespace AccountFinal
{
    class SpecialSavings : Account
    {
        public int TransCount { get; set; }

        public double OBalance { get; set; }

        public int DCount { get; set; }

        public int TransNo { get; set; }


        public SpecialSavings() { }


        public SpecialSavings(string aName, string aNo, double balance, int transNo) : base(aName, aNo, balance)
        {
            this.TransNo = transNo;

            if (DCount == 1)
            {
                OBalance = balance;

            }
            OBalance = balance;
            DCount++;
        }

        public override void Withdraw(double amount)
        {
            TransCount++;
            if ((TransCount <= TransNo) && (Balance - amount >= (OBalance / 5)))
            {
                Balance -= amount;
                Console.WriteLine("Ssa withdraw successfull");
            }
            else
            {
                if (TransCount > TransNo)
                {
                    Console.WriteLine("Min transaction reached");
                }

                else
                    Console.WriteLine("inadequate Balance");
            }

        }

    }
}
