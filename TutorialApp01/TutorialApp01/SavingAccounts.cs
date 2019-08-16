using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialApp01
{
    class SavingAccounts
    {
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;

        /// domyslny konstruktor, jesli nie podamy zadnych argumentow to i tak przejdzie
        public SavingAccounts()
        {

        }
        public SavingAccounts(string accountNumber,
            decimal balance, string firstName, string lastName, long pesel)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;

        }

        public string getfullName()
        {
            return string.Format("{0} {1}",FirstName,LastName);
        }

        public string getBalance()
        {
            return string.Format("{0}zł", Balance);
        }
    }
}
