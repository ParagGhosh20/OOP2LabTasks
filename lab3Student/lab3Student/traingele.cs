using System;
using System.Collections.Generic;
using System.Text;

namespace labTask3
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;
        public void triangle(int X, int Y, int Z)
        {
            a = X;
            b = Y;
            c = Z;
        }
        public void display()
        {
            Console.Write(" X = " + a);
            Console.Write(", Y = " + b);
            Console.WriteLine(", Z = " + c);
        }
        public void TestTriangle()
        {
            if (a == b && b == c)
            {
                Console.WriteLine("3 equal sides");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("2 equal sides");
                
            }
            else
            {
                Console.WriteLine("no equal sides");
                
            }
        }
    }

}