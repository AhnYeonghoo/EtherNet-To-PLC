using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class LineOfCreditAccount : BankAccount
    {

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }

        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit)
            : base(name, initialBalance, -creditLimit) { }
    }
}
