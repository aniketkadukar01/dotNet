using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{

    public delegate void Operations();

    public class EventHandler
    {
        public static void payIncomeTax()
        {
            Console.WriteLine("20% income tax deducted.....");
        }

        public static void blockAccount()
        {
            Console.WriteLine("You account is blocked temp.");
        }

        public static void sendEmail()
        {
            Console.WriteLine("in the sendEmail()");
        }

        public static void sendSms()
        {
            Console.WriteLine("in the sendSms()");
        }
    }
}
