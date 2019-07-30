using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BillingAccount : Account
    {
        public BillingAccount(int id, string firstname, string lastname, long pesel)
            :base(id, firstname, lastname, pesel)
        {
        }

        public override string TypeName()
        {
            return "ROZLICZENIOWE";
        }
    }
}
