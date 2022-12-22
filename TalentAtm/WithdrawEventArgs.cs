using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentAtm
{
    public class WithdrawEventArgs:EventArgs
    {

        public decimal Amount { get; set; }
    }
}
