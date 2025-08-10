using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_01
{
    internal class Employee : IEquatable<Employee>
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
            #region Unsafe
            ////Compare object state [Values] with object state [Values]
            //Employee? emp = (Employee?)obj; // Explicit casting 
            //if (emp != null)
            //{
            //    return this.Id == emp.Id &&
            //       this.Name == emp.Name &&
            //        this.Salary == emp.Salary;

            //}
            //else
            //    return false;
            #endregion

            #region Is & AS Operatoer Safe way

            //1-is operator 
            //Return True => object is Empolyee
            //Return False => object is not an employee

            //Emp => pattern matching
            //        if (obj is Employee emp)
            //        {
            //            return Id == emp.Id && Name == emp.Name &&Salary== emp.Salary;
            //}
            //        else
            //            return false;

            // 2- as operator 
            Employee? emp = obj as Employee;
            if (emp != null)
            {
                return Id == emp.Id && Name == emp.Name && Salary == emp.Salary;
            }
            else
                return false;

            #endregion

        }
        //i must override gethashcode

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }

        public bool Equlas(Employee? emp)
        {
            if (emp is not null)
            {
                return Id == emp.Id && Name == emp.Name && Salary == emp.Salary;
            }
            else
                return false;
        }

        
    }
}
