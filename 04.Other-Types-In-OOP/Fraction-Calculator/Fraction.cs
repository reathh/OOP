using System;

namespace Fraction_Calculator
{
    struct Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }


        public int Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("The denominator cannot be 0");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            checked
            {
                int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
                int newDenominator = a.Denominator * b.Denominator;
                return new Fraction(newNumerator, newDenominator);
            }
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            checked
            {
                int newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
                int newDenominator = a.Denominator * b.Denominator;
                return new Fraction(newNumerator, newDenominator);
            }
        }
        public override string ToString()
        {
            return ((double)this.Numerator / this.Denominator).ToString();
        }

    }
}
