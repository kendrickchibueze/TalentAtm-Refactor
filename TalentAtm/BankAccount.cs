using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentAtm
{
    internal class BankAccount:EventArgs
    {
        public string FullName { get; set; }
        public int AccountNumber{ get; set; }
        public Int64 CardNumber{ get; set; }
        public int PinCode { get; set; }
        public decimal Balance { get; set; }

        public bool isLocked { get; set; }
    }


    class WorkWithBankAccount
    {
          //Define one event to notify the bank account details using the custom delegate
        public event EventHandler<BankAccount> BankAccountdetailVerify;       //generic EventHandler<T> delegate

        //Define another event to notify when the bank account  is blocked using built-in EventHandler delegate
        public event EventHandler BlockBankAccount;


           protected virtual void OnBankAccountdetailsVerify(BankAccount bankAccount)
           {
            //Raising Events only if Listeners are attached
            
                if (BankAccountCreated != null)
                {
                    BankAccount e = new BankAccount()
                    {
                            CardNumber = cardnumber,
                          PinCode = pincode
                    };
                    BankAccountdetailVerify(this, e);
                }
          

           }

          protected virtual void OnBlockBankAccount()
          {

            //Raising Events only if Listeners are attached
            
                BlockBankAccount?.Invoke(this, EventArgs.Empty);
          

          }

     
    }

}
