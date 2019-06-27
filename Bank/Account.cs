using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class Account
    {
        public int Id { get; }
        public string AccountNumber { get; }
        public decimal Balance { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public long Pesel { get; }

        public Account(int id, string firstname, string lastname, long pesel)
        {
            Id = id;
            AccountNumber = generateAccountNumber(id);
            FirstName = firstname;
            LastName = lastname;
            Balance = 0.0M;
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
            var accountNumber = string.Format("94{0:d10}", id);

            return accountNumber;
        }
    }
}
