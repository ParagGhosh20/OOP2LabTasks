using System;
public class Student
{
    private String name;
    private String id;
    private String department;
    private double cgpa;
    public void insert(String Name, String Id, String Department, double Cgpa)
    {
        this.name = Name;
        this.id = Id;
        this.department = Department;
        this.cgpa = Cgpa;
    }
    public void ShowInfo()
    {
        Console.WriteLine("Name "+ name);
        Console.WriteLine("Id " + id);
        Console.WriteLine("Department " + department);
        Console.WriteLine("Cgpa " + cgpa);
    }


}