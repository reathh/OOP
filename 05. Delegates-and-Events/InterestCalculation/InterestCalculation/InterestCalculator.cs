
namespace InterestCalculation
{
    using System;

    // define a class 
    public class InterestCalculator
    {
        // define fields
        private decimal money;
        private double interest;
        private byte years;
        private CalculateInterest intrsCalcDeleg;
        private decimal result;

        // define properies for money and interest to check their values
        private decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("sum amount", "Amount of money can not be a negative number");
                }

                this.money = value;
            }
        }

        private double Interest
        {
            get { return this.interest; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest", "Interest rate can not be a negative number");
                }

                this.interest = value;
            }
        }

        private decimal Result
        {
            get { return this.result; }
            set
            {
                this.result = this.intrsCalcDeleg(this.money, this.interest, this.years);
            }
        }

        // define a constructor
        public InterestCalculator(decimal money, double interest, byte years, CalculateInterest intrsCalcDeleg)
        {
            this.Money = money;
            this.Interest = interest;
            this.years = years;
            this.intrsCalcDeleg = new CalculateInterest(intrsCalcDeleg);
            this.Result = result;
        }

        // a method to calculate and print the result on the console
        public void PrintInterest()
        {
            Console.WriteLine(result.ToString("0.0000"));
        }
    }
}
