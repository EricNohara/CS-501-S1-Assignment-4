using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Bank_Account_Challenge
{
    internal class BankAccount
    {
        //private fields
        private String accountNumber;   //unique account identifier
        private String accountHolderName;   //name of account owner
        private decimal balance;       //current account balance

        //public properties
        public String AccountNumber { 
            get
            {
                return accountNumber;
            }
        }
        public String AccountHolderName
        {
            get
            {
                return accountHolderName;
            }
            set
            {
                accountHolderName = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        //methods
        public BankAccount(String accountNumber, String accountHolderName)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            balance = 0.0m;
        }

        public void deposit(decimal amount)
        {
            if (amount < 0) { throw new Exception(); }
            balance += amount;
        }

        public void withdraw(decimal amount)
        {
            if (balance < amount || amount < 0)
            {
                throw new Exception();
            } 
            else
            {
                balance -= amount;
            }
        }

        override public String ToString()
        {
            String output =
                "Account Number: " + accountNumber
                + "\nAccount Holder: " + accountHolderName
                + "\nAccount Balance: " + balance.ToString("C");
            return output;
        }


    }
}
