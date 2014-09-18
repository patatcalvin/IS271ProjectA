using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoanCalculator;

namespace LoanApplicationTest
{
    [TestClass]
    public class BaseLoanTest
    {
        [TestMethod]
        public void LoanPaymentCacluationTest()
        {
            LoanApplication tL = new LoanApplication();
            tL.amount = 40000;
            tL.loanPaymentCalculation();
            int testAmount = 40000 / 12;
            Assert.AreEqual(testAmount, tL.payment, "Error: payment is wrong.");
        }
    }
}
