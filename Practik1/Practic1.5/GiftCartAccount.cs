using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik1
{
    class GiftCartAccount:BankAccount
    {
        public GiftCartAccount(string fullname, decimal initialBalance)
            : base(fullname, initialBalance)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            MakeWithdrawal(-Balance, DateTime.Now, "Note");
        }
    }
}
