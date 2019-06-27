using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Account
    {
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;

        public Account(string accountnumber, string firstname, string lastname, decimal balance, long pesel)
        {
            AccountNumber = accountnumber;
            FirstName = firstname;
            LastName = lastname;
            Balance = balance;
            Pesel = pesel;
        }

        public abstract string TypeName();

        public string GetFullName()
        {
            string fullName = string.Format("{0} {1}", FirstName, LastName);

            return fullName;
        }

        public string GetBalance()
        {
            return string.Format("{0}zł ", Balance);
        }
    }
}
