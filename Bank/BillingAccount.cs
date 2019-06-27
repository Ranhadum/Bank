using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BillingAccount : Account
    {
        public BillingAccount(string accountnumber, string firstname, string lastname, decimal balance, long pesel)
            :base(accountnumber, firstname, lastname, balance, pesel)
        {
        }

        public override string TypeName()
        {
            return "ROZLICZENIOWE";
        }
    }
}
