using System;
using System.Collections.Generic;
using System.Text;

namespace AccountFinal
{
    abstract class Account
    {
        abstract public void Withdraw(double ammount);
        public string AName { get; set; }

        public string ANo { get; set; }

        public double Balance { get; set; }



        public Account() { }
        

        public Account(string aName, string aNo, double balance)
        {
            this.AName = aName;
            this.ANo = aNo;
            this.Balance = balance;
        }

        public void Deposite(double ammount)
        {

            Balance += ammount;


        }

        

        virtual public void ShowInfo()
        {
            Console.WriteLine(" Name: " + AName);
            Console.WriteLine(" No: " + ANo);
            Console.WriteLine(" balance: " + Balance);
        }

    }
}