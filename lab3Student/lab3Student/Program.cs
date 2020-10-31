using System;


namespace labTask3
{
    class TestStudent
    {
        public static void Main(string[] args)
        {
            Student ob = new Student();
            ob.student("Parag", "19-40085-1", "CSE", 3.51);
            ob.ShowInfo();
            Triangle ob1 = new Triangle();
            ob1.triangle(25, 85, 9);
            ob1.display();
            ob1.TestTriangle();
            Account ob2 = new Account();
            ob2.account("Parag", "000-22-22-22", 2000);
            ob2.output();
            ob2.Deposit(6000);
            ob2.Withdraw(3000);
            Course ob3 = new Course();
            ob3.course("Oop2", "c#", 3);
            ob3.ShowCourseInfo();

        }
    }
}
