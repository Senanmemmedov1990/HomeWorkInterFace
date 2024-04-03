﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolymorphism__Abstraction__Abstract__Interface
{
    internal interface IAccount
    {
       
        public void Deposit(double value);

        public void Withdraw(double value);

        public void CalculateInterest();

    }
}
