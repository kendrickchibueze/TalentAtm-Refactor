using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentAtm
{
    public class MyEventHandlers
    {

        //subscriber event handlers
        public  void HandleOnBankAccountdetail(object sender, BankAccount e)
        {

            switch (LangChoice._choice)
            {
                case 1:

                    Utility.PrintColorMessage(ConsoleColor.Cyan, $"\nChecking card number and password for cardNumber {e.CardNumber}...");
                    Utility.printDotAnimation();
                    break;
                case 2:

                    Utility.PrintColorMessage(ConsoleColor.Cyan, $"\nka olele card number gi ya na password cardi {e.CardNumber}...");
                    Utility.printDotAnimation();
                    break;
                case 3:

                    Utility.PrintColorMessage(ConsoleColor.Cyan, $"\n i de check your card number and password for card {e.CardNumber}...");
                    Utility.printDotAnimation();
                    break;
                default:
                    Utility.PrintColorMessage(ConsoleColor.Cyan, $"\nChecking card number and password for cardNumber {e.CardNumber} ...");
                    Utility.printDotAnimation();
                    break;


            }
            

        }


        public void HandleOnCheckBalance(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine($"checking balance...");
            Utility.printDotAnimation();
        }


        public void HandleOnDeposit(object sender, Deposit e)
        {
            Console.WriteLine($"Ready to deposit {e.Amount}");
        }



        public void HandleOnWithdraw(object sender, BankAccount e)
        {

           
            Console.WriteLine($"Making some withdrawals of {e.Balance}....");
        }

        public static void HandleOnBlockBankAccount(object sender, EventArgs e)
        {
            Console.WriteLine($" Sorry, this account has been blocked...");
        }


        public void HandleViewTransactions(object sender, BankAccount bankAccount)
        {
            Console.WriteLine("Viewing Transactions...");
        }
    }
}
