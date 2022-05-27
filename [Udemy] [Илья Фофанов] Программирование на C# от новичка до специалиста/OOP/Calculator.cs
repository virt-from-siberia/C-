using System;

namespace OOP
{
    public class Calculator
    {
        public double Average(int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }
        public double Average2(params int[] numbers)
        {
            double sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }

        public double CalcTriangleSquare(double ab, double bc, double ac )
        {
            double p = (ab + bc + ac) / 2;
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }
        public double CalcTriangleSquare(double b, double h )
        {
            return 0.5 * b * h;
        }
        public double CalcTriangleSquare(double ab, double ac, int alpha, bool isInRadians = false)
        {
            if (isInRadians)
                return 0.5 * ab * ac * Math.Sin(alpha);
            double rads = alpha * Math.PI / 180;
            return 0.5 * ab * ac * Math.Sin(rads);
        }
        public bool TryDivide(double devisible, double devisor, out double result)
        {
            result = 0;
            if (devisor == 0)
                return false;
            result = devisible / devisor;
            return true;
        }
    }
}