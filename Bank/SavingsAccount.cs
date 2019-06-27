using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SavingsAccount :  Account
    {
        public SavingsAccount(int id, string firstname, string lastname, long pesel)
            :base(id, firstname, lastname, pesel)
        {
        }

        public override string TypeName()
        {
            return "OSZCZĘDNOŚCIOWE";
        }
    }
}
