using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public class BankAccount
    {
        protected double interestRate;
        protected string owner;
        protected decimal balance;

        public BankAccount(string O, decimal B, double iR)
        {
            this.interestRate = iR;
            this.owner = O;
            this.balance = B;
        }

        public BankAccount(string O, double iR) : this(O, 0.0M, iR)
        { }

        public virtual decimal Balance
        {
            get { return balance; }
        }

        public virtual void Withraw(decimal amount)
        {
            this.balance -= amount;
        }

        public virtual void Deposit(decimal amount)
        {
            this.balance += amount; ;
        }

        public virtual void AddInterest()
        {
            balance += balance * (Decimal)interestRate;
        }

        public virtual string Print()
        {
            return owner + "'s account holds" + balance + "лв.";
        }
    }
}
