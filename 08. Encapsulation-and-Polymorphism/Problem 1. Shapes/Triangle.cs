using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Shapes
{
    class Triangle: BasicShape
    {
        private double a;
        private double b;
        private double c;
        private double p;

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.p = (this.A + this.B + this.C) / 2;
        }

        public double A
        {
            get
            {
                return this.a;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Write positive number");
                    }
                    this.a = value;
                }
                catch (FormatException)
                {
                    
                    throw new FormatException("Write NUMBER");
                }
                
            }
        }

        public double B
        {
            get
            {
                return this.b;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Write positive number");
                    }
                    this.b = value;
                }
                catch (FormatException)
                {

                    throw new FormatException("Write NUMBER");
                }

            }
        }

        public double C
        {
            get
            {
                return this.c;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Write positive number");
                    }
                    this.c = value;
                }
                catch (FormatException)
                {

                    throw new FormatException("Write NUMBER");
                }

            }
        }

        public override double CalculateArea()
        {
            return Math.Sqrt(this.p * (this.p - this.A) * (this.p - this.B) * (this.p - this.C));
        }

        public override double CalculatePerimeter()
        {
            return this.p * 2;
        }
    }
}
