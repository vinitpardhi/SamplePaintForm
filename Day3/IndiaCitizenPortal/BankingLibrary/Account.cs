using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public delegate void Operation();
    public class Account
    {
        public event Operation UnderBalance;
        public event Operation OverBalance;
        private double balance;

        public Account(double balance)
        {
            this.Balance = balance;
        }

        public double Balance { get => balance; set => balance = value; }

        public void Deposit(double amount)
        {
            this.balance += amount;
            Monitor();
        }
        
        public void Withdraw(double amount)
        {
            
            this.balance -= amount;
            Monitor();

        }

        void Monitor()
        {
            if(balance < 5000)
            {
                UnderBalance();
            }
            else if(balance > 500000)
            {
                OverBalance();
            }
        }

        public override string ToString()
        {
            return "Current balance is "+Balance;
        }
    }
}
