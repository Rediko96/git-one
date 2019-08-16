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
            var name = "Bank";
            var author = "Marek Zajac";            
            SavingAccounts savingsAccount = new SavingAccounts();
            savingsAccount.AccountNumber = "940000000001";
            savingsAccount.Balance = 0.0M;
            savingsAccount.FirstName = "Marek";
            savingsAccount.LastName = "Zajac";
            savingsAccount.Pesel = 92010133333;
            writeData(savingsAccount,name,author);

            SavingAccounts savingsAccount2 = new SavingAccounts();
            savingsAccount.AccountNumber = "940000000001";
            savingsAccount.Balance = 0.0M;
            savingsAccount.FirstName = "Marek";
            savingsAccount.LastName = "Zajac";
            savingsAccount.Pesel = 92010133333;
            writeData(savingsAccount, name, author);

            BillingAcount billingsAccount = new BillingAcount();
            billingsAccount.AccountNumber = "940000000001";
            billingsAccount.Balance = 0.0M;
            billingsAccount.FirstName = "Marek";
            billingsAccount.LastName = "Zajac";
            billingsAccount.Pesel = 92010133333;
            //writeData(billingsAccount, name, author);

        }
        public static void writeData(SavingAccounts savingsAccount = null,string name, string author)
        {
            Console.WriteLine("Nazwa: {0}",name);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine();
            Console.WriteLine("Dane konta:");
            Console.WriteLine("Numer konta: {0}", savingsAccount.AccountNumber);
            Console.WriteLine("Saldo: {0}zł", savingsAccount.Balance);
            Console.WriteLine("Imię właściciela: {0}", savingsAccount.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", savingsAccount.LastName);
            Console.WriteLine("PESEL właściciela: {0}", savingsAccount.Pesel);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
