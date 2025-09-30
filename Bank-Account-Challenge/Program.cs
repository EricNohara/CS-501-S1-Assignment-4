using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Challenge
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            runProgram();   
        }

        static private void runProgram()
        {
            String num = "";
            String name = "";
            Console.WriteLine("Enter an account number:");
            //get the account number. Make sure it is a valid account number
            while (true)
            {
                try
                {
                    num = Console.ReadLine();
                    if (int.Parse(num) < 0) { throw new Exception(); }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter a valid nonnegative integer.");
                }
            }
            Console.WriteLine("Enter account holder name:");
            //get name. No validation necessary; let them name themselves whatever they want.
            name = Console.ReadLine();

            //create the account object
            BankAccount account = new BankAccount(num, name);

            Console.WriteLine("Account created successfully!");

            inputCycle(account);
        }

        //this method repeatedly asks the user what they want to do
        static private void inputCycle(BankAccount account)
        {
            while(true)
            {
                //request input
                Console.WriteLine(
                    "Select the number of an option:"
                    + "\n1) Deposit"
                    + "\n2) Withdraw"
                    + "\n3) Show account summary"
                    + "\n4) Exit"
                    );
                String selection = Console.ReadLine();
                //validate the input
                try
                {
                    int s = int.Parse(selection);
                    if (s < 1 || s > 4) { throw new Exception(); }
                } 
                catch (Exception) 
                {
                    Console.WriteLine("Please select the number of a given option.");
                    continue;
                }
                //act based on input
                switch (selection)
                {
                    case "1":
                        deposit(account); break;
                    case "2":
                        withdraw(account); break;
                    case "3":
                        Console.WriteLine(account); break;
                    case "4":
                        Console.WriteLine("Thank you for using the digital bank.");
                        return;

                }
            }
        }

        //method to handle deposits
        static private void deposit(BankAccount account)
        {
            Console.WriteLine("Enter an amount to deposit:");
            String input = "";
            decimal amt = 0.0m;
            try
            {
                input  = Console.ReadLine();
                amt = decimal.Parse(input);
                account.deposit(amt);
                Console.WriteLine("Deposit successful!");
            }
            catch (Exception) 
            {
                //if the input is not a number or the number is invalid, handle as error
                Console.WriteLine("Invalid deposit amount: " + input + ". Deposit cancelled.");
                return;
            }
        }

        //method to handle withdrawals
        static private void withdraw(BankAccount account)
        {
            Console.WriteLine("Enter an amount to withdraw:");
            String input = "";
            decimal amt = 0.0m;
            try
            {
                input = Console.ReadLine();
                amt = decimal.Parse(input);
                account.withdraw(amt);
                Console.WriteLine("Withdrawal successful!");
            }
            catch (Exception)
            {
                //if the input is not a number or the number is invalid, handle as error
                Console.WriteLine(
                    "Invalid withdrawal amount: " + input 
                    + ". Current account balance is " + account.Balance.ToString("C")
                    + ". Withdrawal cancelled."
                    );
                return;
            }
        }
    }
}