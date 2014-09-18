using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    public class LoanApplication
    {
        public double annualIncome { get; set; }
        public int creditScore { get; set; }
        public int age { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public int payment { get; set; }

        public void loanPaymentCalculation()
        {
            payment = amount / 12;
        }

        public bool loanApplicationAcceptance()
        {
            return (name.Length > 2);
        }

    }
}
