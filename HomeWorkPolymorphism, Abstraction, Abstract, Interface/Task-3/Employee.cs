using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolymorphism__Abstraction__Abstract__Interface
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public int Employeeld {  get; set; }
        public int BasicSalary { get; set; }

        public abstract void CalculateSalary();
    }
}
