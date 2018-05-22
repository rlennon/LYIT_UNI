using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyitOnlinePayment
{
    class 98692921Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Student Number:");
            var s = Console.ReadLine();

            Console.WriteLine("Enter your Password:");
            var p = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Welcome " + s);
            printPaymentInfo();
            
            // Keep the console window open in debug mode.          
            Console.ReadKey();
        }

        public static void printPaymentInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("Payment Information");
            Console.WriteLine("----------------------");
            Console.WriteLine("01/05/2018  75.85   Pending");
            Console.WriteLine("01/04/2018  75.85   Paid");
            Console.WriteLine("01/03/2018  75.85   Paid");
            Console.WriteLine("01/02/2018  75.85   Paid");
            Console.WriteLine("01/01/2018  75.85   Paid");
        }
    }
}
