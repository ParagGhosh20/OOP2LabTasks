
using System;
namespace labTask3

{
    class Account
    {
        private String accName;
        private String acid;
        private int balance;
        public void account(String AccName, String Acid, int Balance)
        {
            accName = AccName;
            acid = Acid;
            balance = Balance;
        }

        public void output()
        {
            Console.WriteLine("Account Name :" + accName);
            Console.WriteLine("Account Id :" + acid);
            Console.WriteLine("Balance :" + balance);
        }

        public void Deposit(int amount)
        {
            balance = amount;
            Console.WriteLine("Deposite " + balance);
        }
        public void Withdraw(int amount)
        {
            balance = amount;
            Console.WriteLine("Withdraw " + balance);
            
        }

    }

}