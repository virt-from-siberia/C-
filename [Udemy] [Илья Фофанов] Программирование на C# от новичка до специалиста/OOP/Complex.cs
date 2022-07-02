namespace OOP
{
    public class Complex
    {
        public double Imagenary { get; private set; }
        public double Real { get; private set; }

        public Complex(double imagenary, double real)
        {
            Imagenary = imagenary;
            Real = real;
        }

        private Complex()
        {
        }

        public Complex Plus(Complex other)
        {
            var complex = new Complex();
            complex.Imagenary = other.Imagenary + Imagenary;
            complex.Real = other.Real + Real;
            return complex;
        }

        public Complex Minus(Complex other)
        {
            var complex = new Complex();
            complex.Imagenary = other.Imagenary - Imagenary;
            complex.Real = other.Real - Real;
            return complex;
        }
    }
}