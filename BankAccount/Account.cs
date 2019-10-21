using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAccount
{
    [Serializable]
    public class Account
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double Balance { get; private set; }

        public Account(string accountNumber, string accountName):this()
        {
                AccountNumber = accountNumber;
                AccountName = accountName;
        }

        private Account()
        {
            Balance = 0;
        }

        public string Deposite(double amount)
        {
            if(amount > 0)
            {
                Balance = Balance + amount;
                return "Deposite Successsully!";
            }
            return "Deposite amount must be greater than 0 Tk.";
        }

        public string Withdraw(double amount)
        {
            if(Balance >= amount)
            {
                Balance = Balance - amount;
                return "Withdrwaw Successsull!";
            }
            return "Insufficient Balance!"; 
        }

        public string ShowReport()
        {
            return "Hello! " + AccountName + " your account number is " + AccountNumber +
                   " and your balance is " + Balance + " Tk.";
        }
    }
}