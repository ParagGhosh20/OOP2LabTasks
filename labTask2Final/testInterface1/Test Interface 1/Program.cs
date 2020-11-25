using System;

namespace Test_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            BasicCalculator ob = new BasicCalculator();
            Console.WriteLine("Sum : " + ob.Sum(12, 13));
            Console.WriteLine("Sub : " + ob.Sub(12, 13));
            Console.WriteLine("Multiplication : " + ob.Multiplication(2, 3));
            Console.WriteLine("Division : " + ob.Division(12, 6));


            ScientificCalculator ob2 = new ScientificCalculator();


            Console.WriteLine("Power : " + ob2.XtoY(3, 3));
            Console.WriteLine("Root : " + ob2.Root(64));
            Console.WriteLine("Log : " + ob2.Logarithm(1));
           


        }
    }
}