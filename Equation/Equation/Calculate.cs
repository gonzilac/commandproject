using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Calculate
    {
        public Calculate()
        {


        }

        public double[] Calc(double a, double b, double c)
        {
            double[] result = new double[2];
            double d = Math.Pow(b, 2.0) - 4.0 * a * c;
            result[0] = (-b + Math.Sqrt(d)) / 2.0 * a;
            result[1] = (-b - Math.Sqrt(d)) / 2.0 * a;
            return result;
        }
    }
}
