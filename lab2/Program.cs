using System;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)

        {
            //task1
            Console.WriteLine("Task 1");
            Console.WriteLine();
            Console.Write("Print  even numbers from 1 to 10 is : ");
            for (int i = 1; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " + i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //task2 
            Console.WriteLine("Task 2");
            Console.WriteLine();
            int x = 0;
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j <= 5; j++)
                {
                    x = i + j;
                    if (x % 2 == 0)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write("0");
                    }


                }
                Console.WriteLine();

            }
            Console.WriteLine();
            //task3
            Console.WriteLine("Task 3");
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                x = i;

                for (int j = 0; j <= 4; j++)
                {
                    Console.Write(x + j);
                }
                Console.WriteLine();
            }

        }
    }
}