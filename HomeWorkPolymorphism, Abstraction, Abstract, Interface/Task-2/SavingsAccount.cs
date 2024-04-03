using HomeWorkPolymorphism__Abstraction__Abstract__Interface.Task_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolymorphism__Abstraction__Abstract__Interface
{
    internal class SavingsAccount : Account,IAccount
    {

        public void CalculateInterest()
        {
            throw new NotImplementedException();
        }

        public void Deposit(double value)
        {
            throw new NotImplementedException();
        }

        public override void ShowAccountDetails()
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double value)
        {
            throw new NotImplementedException();
        }
    }
}
