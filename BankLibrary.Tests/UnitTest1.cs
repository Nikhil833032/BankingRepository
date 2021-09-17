using System;
using NUnit.Framework;
using BankingLibrary;

namespace BankLibrary.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Calculate_AcceptsPNR_ReturnsSI()
        {
            int ExpectedResults = 1000;
            ICalcInterest cal = new CalcInterest();
            int ActualResult = cal.Calculate(10000, 1, 10);
            Assert.AreEqual(ExpectedResults, ActualResult);
        }
    }
}
