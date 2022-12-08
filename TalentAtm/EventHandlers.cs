using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentAtm
{
    public class EventHandlers
    {

        //subscriber event handlers
        public void HandleOnBankAccountdetail(object sender, BankAccount bankAccount)
        {

            Console.WriteLine($"Handling bank detail verification for {bankAccount.FullName}");

        }


        public void HandleOnCheckBalance(object sender, BankAccount bankAccount)
        {

            Console.WriteLine($"Handling check balance for {bankAccount.FullName} with Balance of {bankAccount.Balance}");
        }


        public void HandleOnDeposit(object sender, BankAccount bankAccount)
        {
            Console.WriteLine("Handling deposit...");
        }



        public void HandleOnWithdraw(object sender, BankAccount bankAccount)
        {
            Console.WriteLine("Handling withdrawal event...");
        }

        public void HandleOnBlockBankAccount(object sender, BankAccount bankAccount)
        {
            Console.WriteLine("Blocking bank account...");
        }


        public void HandleViewTransactions(object sender, BankAccount bankAccount)
        {
            Console.WriteLine("Viewing Transactions...");
        }
    }
}
