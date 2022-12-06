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


    public class WorkWithBankAccount
    {
        

        public delegate void BankAccountdetailEventHandler(object sender, BankAccount bankAccount);

        //Define another event to notify when the bank account  is blocked using built-in EventHandler delegate

        public event EventHandler BlockBankAccount;

        public event BankAccountdetailEventHandler BankAccountdetail;

        public event EventHandler BalanceCheck;

        public event EventHandler Deposit;

        public event EventHandler Withdraw;

        public event EventHandler viewingTransaction;
       
            
          

           protected virtual void OnBankAccountdetail(int pincode, Int64 cardNumber)
           {

                BankAccountdetail?.Invoke(this, new BankAccount() {
                    CardNumber = cardNumber,
                    PinCode = pincode
                    
                
                
                });

           
          

           }

        protected virtual void OnViewTransactions(BankAccount bankAccount)
        {
            viewingTransaction?.Invoke(this, new BankAccount()
            {
                AccountNumber = bankAccount.AccountNumber
            });
        }

          protected virtual void OnCheckBalance(BankAccount bankAccount)
           {
            BalanceCheck?.Invoke(this, new BankAccount() { Balance = bankAccount.Balance});

            

           }


           protected virtual void OnDeposit(BankAccount bankAccount)
           {

                Deposit?.Invoke(this, new BankAccount() { 
                    AccountNumber = bankAccount.AccountNumber,
                    Balance = bankAccount.Balance
                });

            

           }

        protected virtual void OnWithdraw(BankAccount bankAccount)
        {
            Withdraw?.Invoke(this, new BankAccount() {
            AccountNumber = bankAccount.AccountNumber,
            Balance= bankAccount.Balance
            });

        }

         protected virtual void OnBlockBankAccount(bool isLocked)
          {

            //Raising Events only if Listeners are attached
            
                BlockBankAccount?.Invoke(this, new BankAccount()
                {
                    isLocked = true,
                });
          

          }

     
    }

}
