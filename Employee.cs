using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Collection_Generics
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, string gender, double salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}
