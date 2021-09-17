using System;

namespace BankingLibrary
{
    public interface ICalcInterest
    {

        public int Calculate(int Principle, int years, int RateOfInt);
    }
}
