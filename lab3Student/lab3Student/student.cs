using System;
public class Student
{
    private String name;
    private String id;
    private String department;
    private double cgpa;
    public void student(String Name, String Id, String Department, double Cgpa)
    {
        name = Name;
        id = Id;
        department = Department;
        cgpa = Cgpa;
    }
    public void ShowInfo()
    {
        Console.WriteLine("Name " + name);
        Console.WriteLine("Id " + id);
        Console.WriteLine("Department " + department);
        Console.WriteLine("Cgpa " + cgpa);
    }


}