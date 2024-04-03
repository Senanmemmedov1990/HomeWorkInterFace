using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolymorphism__Abstraction__Abstract__Interface.Task_2
{
    internal abstract class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }


        public abstract void ShowAccountDetails();
    }
}
