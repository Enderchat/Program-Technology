using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practik1
{
    class InterestEarningAccount:BankAccount
    {
        public InterestEarningAccount(string fullname, decimal initialBalance)
            : base(fullname, initialBalance)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
                MakeDeposit(Balance * 0.1m, DateTime.Now, "apply monthly interest");
        }
    }
}
