using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingHandlers
{
    public class AccountListener
    {
        public static void CardBlock()
        {
            Console.WriteLine("Your card has been blocked : Minimum balance requirement breached");
        }

        public static void SendMail()
        {
            Console.WriteLine("Email has been sent to your mail-id");
        }
    }
}
