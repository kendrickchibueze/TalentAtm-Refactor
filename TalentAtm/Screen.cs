using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentAtm
{



    //we are storing items as key value pairs with enums
    public enum Menu
    {
        // Value 1 is needed because menu starts with 1 while enum starts with 0 if no value given.

        [Description("Check balance")]
        CheckBalance = 1,

        [Description("Deposit")]
        PlaceDeposit = 2,

        [Description("Withdrawal")]
        MakeWithdrawal = 3,

        [Description("Transfer")]
        Transfer = 4,

        [Description("Transaction")]
        ViewTransaction = 5,

        [Description("Logout")]
        Logout = 6
    }
     static class Screen
    {

        internal static string _currency = "$";

        
        public static VmTransfer TransferMoney()
        {
            var vMTransfer = new VmTransfer();

            
            vMTransfer.RecipientBankAccountNumber = Utility.GetIntInputAmount("recipient's account number");

            
            vMTransfer.TransferAmount = Utility.GetDecimalInputAmt("amount");

            
            vMTransfer.RecipientBankAccountName = Utility.GetRawInput("recipient's account name");
            

            return vMTransfer;
        }







        public static void ShowMenuOne()
        {
            Console.Clear();
            Utility.PrintColorMessage(ConsoleColor.Yellow ," ------------------------");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"| TalentBank ATM Menu    |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"|                        |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"| 1. Insert ATM card     |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"| 2. Exit                |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"|                        |");
            Utility.PrintColorMessage(ConsoleColor.Yellow," ------------------------");
        }

        public static void ShowMenuTwo()
        {
            Console.Clear();
            Utility.PrintColorMessage(ConsoleColor.Yellow," ---------------------------");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"| TalentBank ATM Secure Menu |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"|                            |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"| 1. Balance Enquiry         |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"| 2. Cash Deposit            |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"| 3. Withdrawal              |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"| 4. Transfer                |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"| 5. Transactions            |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"| 6. Logout                  |");
            Utility.PrintColorMessage(ConsoleColor.Yellow,"|                            |");
            Utility.PrintColorMessage(ConsoleColor.Yellow, " ---------------------------");
        }

    
    }








}
