using System;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)

        {
            //lab2task1
            Console.WriteLine("lab2task1");
            Console.WriteLine();
            Console.Write("even numbers are : ");
            
            for (int i = 1; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " + i);
                }
               
            }
            Console.WriteLine();


            //lab2task2 
            Console.WriteLine();
            Console.WriteLine("lab2task2");
            
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


            //lab2task3
            Console.WriteLine("lab2task3");
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
            Console.WriteLine();

            //lab2task4
            Console.WriteLine("lab2task4");
            Console.WriteLine();

            {


                int oSum = 0;
                int eSum = 0;

                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                        eSum = eSum + i;
                    else
                        oSum = oSum + i;
                }
                Console.WriteLine("sum of odd " + oSum);
                Console.WriteLine("sum of even" + eSum);
            }
            Console.WriteLine();


            //lab2task5
            Console.WriteLine("lab2task5");
            Console.WriteLine();
            

            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= 5; j++)
                {

                    if (i == j)
                    {
                        Console.Write(j);
                    }
                    else

                        Console.Write(" ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();


            //lab2task6
            Console.WriteLine("lab2task6");
            Console.WriteLine();

            int c = 1;
            Console.WriteLine("factorial of 12 ");
            
            for (int i = 1; i <= 12; i++)

            {
                c = c * i;
                Console.WriteLine(c);
            }
            Console.WriteLine();


            //lab2task7
            Console.WriteLine("lab2task7");
            Console.WriteLine();
            
                  int n = 6;
                        for (int a = 1; a < n; a++)
                        {
                            for (int b = 1; b <=a; b++)
                            {
                                Console.Write("*");

                            }
                            Console.WriteLine();

                        }


                        for (int a = 1; a < n; a++)
                        {
                            for (int b = n-2; b >= a; b--)
                            {
                                Console.Write("*");

                            }
                            Console.WriteLine();



                        }

                        Console.WriteLine();
                       
        















        }
    }
}