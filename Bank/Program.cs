using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bank";
            string author = "Ja";

            Console.WriteLine("Program: "+ name);
            Console.WriteLine("Autor: "+ author);
            Console.WriteLine();

            Account savingsAccount = new SavingsAccount(1, "Janusz", "Klepka", 95071711111);

            Account savingsAccount2 = new SavingsAccount(2, "Andrzej", "Warchol", 87040322222);

            Account billingAccount2 = new BillingAccount(3, savingsAccount2.FirstName, savingsAccount2.LastName, savingsAccount2.Pesel);

            IPrinter printer = new Printer();
            IPrinter smallprinter = new SmallPrinter();

            printer.Print(savingsAccount);
            printer.Print(savingsAccount2);
            printer.Print(billingAccount2);
            smallprinter.Print(savingsAccount);

            Console.ReadKey();
        }
    }
}
