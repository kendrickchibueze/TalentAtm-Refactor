using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TalentAtm
{
     interface ITransaction
    {
        void InsertTransaction(BankAccount bankAccount, Transaction transaction);

        void ViewTransaction(BankAccount bankAccount);
    }
}
