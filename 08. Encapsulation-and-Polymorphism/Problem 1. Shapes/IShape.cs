using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Shapes
{
    interface IShape
    {
        //IShape with two abstract methods: CalculateArea() and CalculatePerimeter().
		double CalculateArea();
        double CalculatePerimeter();
    }
}
