
namespace InterestCalculation
{
    using System;

    // test the program
    public class InterestCalculatorTest
    {
        static void Main()
        {
            // create two delegates to pass them to the InterestCalculator constructor
            CalculateInterest simpleInterestMethod = InterestCalculationMethods.GetSimpleInterest;
            CalculateInterest compoundInterestMethod = InterestCalculationMethods.GetCompoundInterest;

            // create two objects of the class InterestCalculator 
            var simpleInterest = new InterestCalculator(2500, 7.2, 15, simpleInterestMethod);
            var compoundInterst = new InterestCalculator(500,5.6, 10, compoundInterestMethod);

            // print the result
            simpleInterest.PrintInterest();
            compoundInterst.PrintInterest();
        }
    }
}
