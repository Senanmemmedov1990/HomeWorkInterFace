using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolymorphism__Abstraction__Abstract__Interface
{
    internal class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
