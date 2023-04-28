using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRMApp
{
    public class Account
    {
        public Person AccountHolder;
        public Person AccountOwner;
        public Account ParentAccount;
        public Account(Person accountHolder) 
        { 
            this.AccountHolder = accountHolder;
        }
        public Account(Person accountHolder, Person accountOwner, Account parentAccount)
        {
            this.AccountHolder = accountHolder;
            this.AccountOwner = accountOwner;
            this.ParentAccount = parentAccount;
        }

    }
}