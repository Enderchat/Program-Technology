using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik1
{
    class LineOfCreditAccount :BankAccount
    {
        public LineOfCreditAccount(string fullname, decimal initialBalance)
            :base (fullname, initialBalance)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
                MakeWithdrawal(Balance * 0.2m, DateTime.Now, "Charge monthly interest");
        }
    }
}
