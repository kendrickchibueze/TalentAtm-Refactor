﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentAtm
{
    internal interface ITransfer
    {
        void performTransfer(BankAccount bankAccount, VmTransfer Transfer);
    }
}