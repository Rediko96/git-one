using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialApp01
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

            SavingAccounts savingsAccount = new SavingAccounts("940000000001", 0.0M, "Marek", "Zając", 92010133333);
            SavingAccounts secondSavingsAccount = new SavingAccounts("940000000002", 0.0M, "Marek", "Zając", 92010133333);

            string fullName = savingsAccount.getfullName();
            Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", fullName);

            string fullBalance = savingsAccount.getBalance();
            Console.WriteLine("Twoja wartość konta wynosi: {0}",fullBalance);



            BillingAcount billingsAccount = new BillingAcount(savingsAccount.AccountNumber, savingsAccount.Balance, savingsAccount.FirstName, savingsAccount.LastName,
                savingsAccount.Pesel);
            

            Printer printer = new Printer();

            printer.Print(savingsAccount);
            printer.Print(secondSavingsAccount);
            printer.Print(billingsAccount);

            Console.ReadKey();

        }
        
    }
}
