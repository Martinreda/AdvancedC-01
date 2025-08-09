using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_01
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int _id, string _name, decimal _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
        }

        public override string ToString()
        {
            return $"Id : {Id} | Name {Name} | Salary : {Salary}";

        }

        public override bool Equals(object? obj)
        {
            //Compare object state [Values] with object state [Values]
            Employee? emp = (Employee?)obj; // Explicit casting 
            if (emp != null)
            {
                return this.Id == emp.Id &&
                   this.Name == emp.Name &&
                    this.Salary == emp.Salary;

            }
            else
                return false;
        }
        //i must override gethashcode

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }
    }
}
