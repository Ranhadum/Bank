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

            SavingsAccount savingsAccount = new SavingsAccount("940000000001", "Janusz", "Klepka", 0.0M, 95071711111);

            SavingsAccount savingsAccount2 = new SavingsAccount("940000000002", "Andrzej", "Warchol", 3.27M, 87040322222);

            Account billingAccount2 = new BillingAccount("940000000012", savingsAccount2.FirstName, savingsAccount2.LastName,  1.2M, savingsAccount2.Pesel);

            Printer printer = new Printer();

            printer.Print(savingsAccount);
            printer.Print(savingsAccount2);
            printer.Print(billingAccount2);

            Console.ReadKey();
        }
    }
}
