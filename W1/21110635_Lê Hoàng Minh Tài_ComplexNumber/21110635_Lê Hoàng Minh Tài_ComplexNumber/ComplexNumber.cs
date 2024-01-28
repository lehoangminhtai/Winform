using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21110635_Lê_Hoàng_Minh_Tài_ComplexNumber
{
    class ComplexNumber
    {
        private int real;
        private int imaginary;

        public ComplexNumber() { }
        public ComplexNumber(int a, int b)
        {

            real = a;
            imaginary = b;

        }


        public override string ToString()
        {

            return "(" + real + (imaginary < 0 ? " - " + (imaginary * -1) : " + " + imaginary) + "i )";
        }



        public int Real

        {

            get { return real; }
            set { real = value; }
        }

        // end property Real
        // property Imaginary

        public int Imaginary

        {

            get { return imaginary; }
            set { imaginary = value; }

        } // end property Imaginary

        // overload the addition operator

        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
        {

            return new ComplexNumber(x.Real + y.Real, x.Imaginary + y.Imaginary);
        }


        public static ComplexNumber Add(ComplexNumber x, ComplexNumber y)

        {
            return x + y;

        }

        // overload the subtraction operator

        public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)

        {

            return new ComplexNumber(x.Real - y.Real, x.Imaginary - y.Imaginary);
        }

        // provide alternative to overloaded - operator

        // for subtraction

        public static ComplexNumber Subtract(ComplexNumber x, ComplexNumber y)
        {

            return x - y;
        }




        // overload the multiplication operator

        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)

        {

            return new ComplexNumber(

            x.Real * y.Real - x.Imaginary * y.Imaginary, x.Real * y.Imaginary + y.Real * x.Imaginary);

        }

        public static ComplexNumber Multiply(ComplexNumber x, ComplexNumber y)

        {
            return x * y;
        }
    }
}
