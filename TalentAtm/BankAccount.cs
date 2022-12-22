using System.Runtime.CompilerServices;

namespace TalentAtm
{
    //publisher class


    public class BankAccount : EventArgs
    {
        public string FullName { get; set; }
        public int AccountNumber { get; set; }
        public Int64 CardNumber { get; set; }
        public Int64 PinCode { get; set; }
        public decimal Balance { get; set; }

        public decimal Amount { get; set; }

        public bool isLocked { get; set; }



        public BankAccount()
        {

        }


        public BankAccount(Int64 cardNumber, Int64 pinCode)
        {
            CardNumber = cardNumber;
            PinCode = pinCode;



        }





    }


     class WorkWithBankAccount
    {
        public static bool _passverification;

        private static int _tries;

        public const int _maxTries = 3;

        private static List<BankAccount> _accountList;





        public static BankAccount _selectedAccount;

      


       


        //public delegate void BankAccountdetailEventHandler(object sender, BankAccount bankAccount); //the source and the data we are sending accross is the paraameters



        public static event EventHandler<BankAccount> checkBankAccountdetail;


        public  static event EventHandler<BankAccount> BlockBankAccount;





        public static event EventHandler<BankAccount> BalanceCheck;

        public static event EventHandler<Deposit> Deposit;

        public event EventHandler<BankAccount> Withdraw;

        public event EventHandler<BankAccount> viewingTransaction;




    


        public void OnDeposit(Deposit deposit)
        {
            Deposit?.Invoke(this, deposit); 
        }


        public  void OnBalanceCheck(BankAccount bankAccount)
        {
            BalanceCheck?.Invoke(this, bankAccount);
        }

        public void OnWithdraw(BankAccount bankAccount)
        {
            Withdraw?.Invoke(this, bankAccount);
        }


        //event publisher method
        protected virtual void OnRetrieveBankDetail(BankAccount bankAccount)
        {

            checkBankAccountdetail?.Invoke(this, bankAccount);


        }


        //this method raises the event
        public void BankAccountdetail()
        {


            while (!_passverification)
            {

                Int64 cardNumber;

                switch (LangChoice._choice)
                {
                    case 1:
                        cardNumber = Utility.GetIntInputAmount("ATM Card Number");

                        Utility.PrintColorMessage(ConsoleColor.Yellow, "Enter 4 Digit PIN: ");

                        break;
                    case 2:
                        cardNumber = Utility.GetIntInputAmount("ATM Card Nomba gi");
                        Utility.PrintColorMessage(ConsoleColor.Yellow, "Tinye digiti ano pini gi: ");
                        break;
                    case 3:
                        cardNumber = Utility.GetIntInputAmount("ATM Card Number");
                        Utility.PrintColorMessage(ConsoleColor.Yellow, "Abeg make you put  your 4 digit pin: ");
                        break;
                    default:
                        cardNumber = Utility.GetIntInputAmount("ATM Card Number");
                        Utility.PrintColorMessage(ConsoleColor.Yellow, "Enter 4 Digit PIN: ");
                        break;


                }


                Int64 pinCode = int.Parse(Console.ReadLine());

                OnRetrieveBankDetail(new BankAccount { CardNumber = cardNumber, PinCode = pinCode }); //we invoke the event



                _accountList = new List<BankAccount>
            {
                new BankAccount() { FullName = "Charlse", AccountNumber=333111, CardNumber = 123, PinCode = 1111, Balance = 2000.00m, isLocked = false },

                new BankAccount() { FullName = "Mike", AccountNumber=111222, CardNumber = 456, PinCode = 2222, Balance = 1500.30m, isLocked = true },

                new BankAccount() { FullName = "Leo", AccountNumber=888555, CardNumber = 789, PinCode = 3333, Balance = 2900.12m, isLocked = false }
            };





                foreach (BankAccount account in _accountList)
                {
                    if (cardNumber.Equals(account.CardNumber))
                    {
                        _selectedAccount = account;

                        if (pinCode.Equals(account.PinCode))
                        {
                            if (_selectedAccount.isLocked)
                            {
                                BlockBankAccount += MyEventHandlers.HandleOnBlockBankAccount; // subscribing to the event

                                BlockAccount(true);

                            }


                            else
                                _passverification = true;
                        }
                        else
                        {
                            _passverification = false;
                            _tries++;

                            if (_tries >= _maxTries)
                            {
                                _selectedAccount.isLocked = true;

                                BlockBankAccount += MyEventHandlers.HandleOnBlockBankAccount; //subscribing to the event

                                BlockAccount(true);
                            }

                        }
                    }

                }
                if (!_passverification)
                    switch (LangChoice._choice)
                    {
                        case 1:
                            Utility.PrintMessage("Invalid Card number or Pin.", false);
                            Console.Clear();
                            break;
                        case 2:
                            Utility.PrintMessage("Anyi awotara card nomba gi ya na pin gi.", false);
                            Console.Clear();
                            break;
                        case 3:
                            Utility.PrintMessage("i be like say your card number or pin no dey valid", false);
                            Console.Clear();
                            break;
                        default:
                            Utility.PrintMessage("Invalid Card number or Pin.", false);
                            Console.Clear();
                            break;


                    }

            }

        }




        public  void CheckBalance(BankAccount bankAccount)
        {




            OnBalanceCheck(new BankAccount { 
                Balance = bankAccount.Balance


            });

           

            switch (LangChoice._choice)
            {
                case 1:
                    Utility.PrintMessage($"Your bank account balance amount is: {Utility.FormatAmount(bankAccount.Balance + Atm._transactAmt)}", true);
                    break;
                case 2:
                    Utility.PrintMessage($"Ego gi foro na accountu gi bu: {Utility.FormatAmount(bankAccount.Balance+ Atm._transactAmt)}", true);
                    break;
                case 3:
                    Utility.PrintMessage($"Your money e remain : {Utility.FormatAmount(bankAccount.Balance + Atm._transactAmt)}", true);

                    break;
                default:
                    Utility.PrintMessage($"Your bank account balance amount is: {Utility.FormatAmount(bankAccount.Balance + Atm._transactAmt)}", true);

                    break;


            }

          


           
        }



        //method that raises the event
        private  void BlockAccount(bool islocked)
        {
            Console.Clear();

            OnBlockBankAccount(new BankAccount { isLocked = islocked });

            switch (LangChoice._choice)
            {
                case 1:
                    Utility.PrintMessage("Your account is locked.", islocked);
                    Utility.PrintColorMessage(ConsoleColor.Yellow, "Please go to the nearest branch to unlocked your account.");
                    Utility.PrintColorMessage(ConsoleColor.Yellow, "Thank you for using Talentbank. ");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
                case 2:
                    Utility.PrintMessage("Akpochiri accountu gi.", islocked);
                    Utility.PrintColorMessage(ConsoleColor.Yellow, "Biko jee na branchi anyi di gi nso ka ikpoghe ya.");
                    Utility.PrintColorMessage(ConsoleColor.Yellow, "Ekele maka i bia Talent Bank. ");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
                case 3:
                    Utility.PrintMessage("Your account dey locked.", islocked);
                    Utility.PrintColorMessage(ConsoleColor.Yellow, "Abeg go  nearest branch make you unlocked your account.");
                    Utility.PrintColorMessage(ConsoleColor.Yellow, "Thank you jaire for  using Talentbank. ");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
                default:
                    Utility.PrintMessage("Your account is locked.", islocked);
                    Utility.PrintColorMessage(ConsoleColor.Yellow, "Please go to the nearest branch to unlocked your account.");
                    Utility.PrintColorMessage(ConsoleColor.Yellow, "Thank you for using Talentbank. ");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;


            }

            Environment.Exit(1);
        }

        protected  virtual void  OnBlockBankAccount(BankAccount bankAccount)
        {


            BlockBankAccount?.Invoke(this, bankAccount);    

        }





































        /*public void OnBankAccountdetail(int pincode, Int64 cardNumber)
        {

         BankAccount bankAccount =  new BankAccount();
         bankAccount.CardNumber = cardNumber;
         bankAccount.PinCode = pincode;


         BankAccountdetail?.Invoke(this, bankAccount);   

        }




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


       }*/


    }
}


