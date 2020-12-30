namespace lesson3._1
{
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }

        public Complex Multiply(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = x2.re * this.re - x2.im * this.im;
            x3.im = x2.im * this.re + x2.re * this.im;
            return x3;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
