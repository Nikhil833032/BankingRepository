using System;

namespace BankingLibrary
{
    public class CalcInterest:ICalcInterest
    {
        public int Calculate(int Principle, int years, int RateOfInterest)
        {
            int SimplInt = (Principle * years * RateOfInterest) / 100;
            return SimplInt;
        }
    }
}
