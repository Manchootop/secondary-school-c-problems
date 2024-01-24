using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Bank_Account
{
    class CheckAccount : BankAccount
    {
        public CheckAccount(string o, double ir) :
            base(o, ir)
        {

        }
        public override void Withraw(decimal amount)
        {
            balance -= amount;
            if (amount > balance)
            {
                interestRate = -0.10;
            }
        }
        public override string Print()
        {
            return owner + "'s account holds" + balance + "лв.";
        }
    }
}
