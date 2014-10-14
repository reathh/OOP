
namespace InterestCalculation
{
    using System;

    // define a delegate for calculating interest
    public delegate decimal CalculateInterest(decimal sum, double interest, byte years);

    // define a class to hold the interest calculation methods
    public static class InterestCalculationMethods
    {
        // define a const for the n periods in the year
        private const byte N_PERIODS = 12;

        // define a method for calculating simple interest
        public static decimal GetSimpleInterest(decimal sum, double interest, byte years)
        {
            decimal result = sum * (decimal)(1 + interest/100 * years);
            return result;
        }

        // define a method for calculting compound interest
        public static decimal GetCompoundInterest(decimal sum, double interest, byte years)
        {          
            decimal result = sum * Convert.ToDecimal(Math.Pow(1 + (interest / N_PERIODS/ 100), years * N_PERIODS));
            return result;
        }
    }
}
