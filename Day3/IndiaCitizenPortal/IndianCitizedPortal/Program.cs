using BankingHandlers;
using BankingLibrary;
using GovtLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCitizedPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Account MyAccount = new Account(300000);
            MyAccount.UnderBalance += new Operation(AccountListener.CardBlock);
            MyAccount.UnderBalance += new Operation(AccountListener.SendMail);

            MyAccount.OverBalance += new Operation(UPAGovt.PayIncomeTax);

            Console.WriteLine(MyAccount);

            MyAccount.Deposit(245987);
            Console.WriteLine(MyAccount);
            MyAccount.Withdraw(558700);
            Console.WriteLine(MyAccount);
            Console.ReadLine();
        }
    }
}
