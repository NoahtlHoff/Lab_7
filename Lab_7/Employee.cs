using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Employee
    {
        //Egenskaper
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        //Konstruktor
        public Employee(int id, string name, string gender, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Gender: {Gender}, Salary: {Salary}";
        }
    }
}
