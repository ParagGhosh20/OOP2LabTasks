using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public Employee()
        {
        }
        public Employee(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
        }

    }
}
