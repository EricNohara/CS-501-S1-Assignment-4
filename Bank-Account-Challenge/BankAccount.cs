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

        //constructor
        public BankAccount(String accountNumber, String accountHolderName)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            balance = 0.0m;
        }

        //deposit an amount
        public void deposit(decimal amount)
        {
            if (amount < 0) { throw new Exception(); }  //only allow depositing positive numbers
            balance += amount;
        }

        //withdraw an amount
        public void withdraw(decimal amount)
        {
            if (balance < amount || amount < 0)
            {
                //don't allow withdrawing more than is there
                throw new Exception();
            } 
            else
            {
                balance -= amount;
            }
        }

        //a tostring method to make printing account details easier
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
