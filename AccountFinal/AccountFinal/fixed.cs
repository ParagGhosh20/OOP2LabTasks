using System;
using System.Collections.Generic;
using System.Text;

namespace AccountFinal
{
   class Fixed:Account
    {


        public int CYear { get; set; }

        public int TenureYear { get; set; }

        public Fixed() { }
       

        public Fixed(string aName, string aNo, double balance, int CYear, int TenureYear) : base(aName, aNo, balance)
        {
            

            this.CYear = CYear;
            
            this.TenureYear = TenureYear;

        }
        

        public override void Withdraw(double ammount)
        {
            string currentYear = DateTime.Now.Year.ToString();
            int cyear = Int32.Parse(currentYear);

            if ((cyear - CYear) >= TenureYear && Balance - ammount >= 0)
            {
                Balance -= ammount;
                Console.WriteLine(" withdraw successfull");
            }

            else
            {
                if((cyear - CYear) < TenureYear)
                    Console.WriteLine("not ready for withdraw ammount");
                else
                    Console.WriteLine("not enough balance");
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account Opening Year: " + CYear);
            Console.WriteLine("Account Tenure Year: " + TenureYear);
        }

    }
}
