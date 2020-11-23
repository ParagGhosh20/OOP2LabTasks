using System;

namespace AccountFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            Account ob1 = new Fixed ("FixedA", "account1", 50000.00, 2030, 5);
            Account ob2 = new Savings("SavingA", "account2", 10000.00, 10);
            Account ob3 = new SpecialSavings("SpecialSavingA", "account3", 20000.00, 5);
            Account ob4 = new Overdraft("overdraft", "account4", 500000.00, 2000.00);


            ob1.Withdraw(300);
            ob2.Withdraw(700);
            ob3.Withdraw(800);
            ob4.Withdraw(900);

            

            ob1.Withdraw(7000);
            ob2.Withdraw(80000);
            ob3.Withdraw(6000);
            ob4.Withdraw(65000);

        }
    }
}