using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SavingsAccount :  Account
    {
        public SavingsAccount(string accountnumber, string firstname, string lastname, decimal balance, long pesel)
            :base(accountnumber, firstname, lastname, balance, pesel)
        {
        }

        public override string TypeName()
        {
            return "OSZCZĘDNOŚCIOWE";
        }
    }
}
