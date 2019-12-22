using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovtLibrary
{
    public class NDAGovt
    {
        public static void PayIncomeTax()
        {
            Console.WriteLine("Income tax has been deducted from your account : 15%");

        }

        public static void PayServiceTax()
        {
            Console.WriteLine("Service tax has been deducted from your account : 25%");
        }

        public static void PayGSTTax()
        {
            Console.WriteLine("Goods and Services tax has been deducted from your account : 12%");
        }
    }
}
