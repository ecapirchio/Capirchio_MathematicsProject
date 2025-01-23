using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capirchio_Mathematics
{
    public class AdvMath
    {
        public double CalculateArea(double height, double width)
        {
            return height * width;
        }

        public double CalculateAverage(List<double> values)
        {
            if (values == null || values.Count == 0)
                throw new ArgumentException("List cannot be null or empty");

            double sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum / values.Count;
        }

        public double CalculateSquared(double value)
        {
            return value * value;
        }

        public double CalculateHypotenuse(double a, double b)
        {
            double aSquared = CalculateSquared(a);
            double bSquared = CalculateSquared(b);
            return Math.Sqrt(aSquared + bSquared);
        }
    }
}

