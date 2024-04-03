using HomeWorkPolymorphism__Abstraction__Abstract__Interface.Task_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolymorphism__Abstraction__Abstract__Interface
{
    internal class CurrentAccount : Account,IAccount
    {

        public CurrentAccount(double balance,int accountNum)
        {
            Balance = balance;
            AccountNumber = accountNum;
        }

        public void CalculateInterest()
        {
            throw new NotImplementedException();
        }


        public void Deposit(double value)
        {
            Balance += value;
            Console.WriteLine(Balance);
        }

        public override void ShowAccountDetails()
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double value)
        {
            if (Balance < value)
            {
                Console.WriteLine("Balansda kifayet qeder mebleg yoxdur");
            }
            else Balance -= value;
            Console.WriteLine(Balance);
        }
    }
}
