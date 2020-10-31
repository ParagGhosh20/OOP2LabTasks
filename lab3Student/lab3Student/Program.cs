using System;

using System;

namespace labTask3
{
    class TestStudent
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.insert("Kaushik", "19-40034-1", "CS", 3.50);
            s1.ShowInfo();
            Triangle t1 = new Triangle();
            t1.triangle(10, 10, 10);
            t1.display();
            t1.TestTriangle();
        }
    }
}
