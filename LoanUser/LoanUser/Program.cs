using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanCalculator;

namespace LoanUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            LoanApplication tL = new LoanApplication();
            tL.amount = 120000;
            tL.loanPaymentCalculation();
            Console.WriteLine("Your payment is: " + tL.payment);
        }
    }
}
