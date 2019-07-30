using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SmallPrinter : IPrinter
    {
       public void Print(Account account)
       {
            Console.WriteLine("Numer konta: {0}", account.AccountNumber);
            Console.WriteLine("Imię: {0}", account.FirstName);
            Console.WriteLine("Nazwisko: {0}", account.LastName);
            Console.WriteLine();
       }
    }
}
