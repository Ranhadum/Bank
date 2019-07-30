using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Account
    {
        public int Id;
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;


        public Account(int id, string accountnumber, string firstname, string lastname, decimal balance, long pesel)
        {
            Id = id;
            AccountNumber = generateAccountNumber(id);
            FirstName = firstname;
            LastName = lastname;
            Balance = 0,0M;
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

        private string generateAccountNumber(int id)
        {
            var accountNumber = String.Format("94{0:D10}", id);

            return accountNumber;
        }
    }
}
