using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentAtm
{
    //publisher class
    public class BankAccount:EventArgs
    {
        public string FullName { get; set; }
        public int AccountNumber{ get; set; }
        public Int64 CardNumber{ get; set; }
        public int PinCode { get; set; }
        public decimal Balance { get; set; }

        public bool isLocked { get; set; }
    }


    public  class WorkWithBankAccount
    {
        

        public delegate void BankAccountdetailEventHandler(object sender, BankAccount bankAccount); //the source and the data we are sending accross is the paraameters

        //Define another event to notify when the bank account  is blocked using built-in EventHandler delegate

        public   event BankAccountdetailEventHandler? BankAccountdetail; 

        //public event EventHandler<BankAccount> BankAccountdetail;


      public event EventHandler<BankAccount>? BlockBankAccount;





        public event EventHandler<BankAccount>? BalanceCheck;

        public event EventHandler<BankAccount>? Deposit;

        public event EventHandler<BankAccount>? Withdraw;

        public event EventHandler<BankAccount>? viewingTransaction;
       
            
          

           public void OnBankAccountdetail(int pincode, Int64 cardNumber)
           {

            BankAccount bankAccount =  new BankAccount();
            bankAccount.CardNumber = cardNumber;
            bankAccount.PinCode = pincode;


            BankAccountdetail?.Invoke(this, bankAccount);



                /*BankAccountdetail?.Invoke(this, new BankAccount() {
                    CardNumber = cardNumber,
                    PinCode = pincode
                    
                
                
                });*/

           
          

           }

        /*public void OnViewTransactions(BankAccount bankAccount)
        {
            viewingTransaction?.Invoke(this, new BankAccount()
            {
                AccountNumber = bankAccount.AccountNumber
            });
        }*/

          public void OnCheckBalance(BankAccount bankAccount)
           {
            BalanceCheck?.Invoke(this, new BankAccount() { Balance = bankAccount.Balance});

            

           }


           public void OnDeposit(BankAccount bankAccount)
           {

                Deposit?.Invoke(this, new BankAccount() { 
                    AccountNumber = bankAccount.AccountNumber,
                    Balance = bankAccount.Balance
                });

            

           }

        public void OnWithdraw(BankAccount bankAccount)
        {
            Withdraw?.Invoke(this, new BankAccount() {
            AccountNumber = bankAccount.AccountNumber,
            Balance= bankAccount.Balance
            });

        }

         public bool OnBlockBankAccount(bool isLocked)
          {

            //Raising Events only if Listeners are attached
            
                BlockBankAccount?.Invoke(this, new BankAccount()
                {
                    isLocked = true,
                });
            return isLocked;
          

          }

     
    }

}
