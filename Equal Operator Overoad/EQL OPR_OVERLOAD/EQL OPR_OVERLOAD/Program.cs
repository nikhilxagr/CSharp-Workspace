using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EQL_OPR_OVERLOAD
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        // overload operator + taken two fractions and return a new fraction
        public static Fraction operator +(Fraction lhs, Fraction rhs)
        {
           if (lhs.numerator == rhs.numerator)
            {
                return new Fraction(lhs.numerator + lhs.numerator , rhs.denominator);
            }
        int firstProduct = lhs.numerator * rhs.denominator;
        int secondProduct = rhs.numerator * lhs.denominator;
            return new Fraction(firstProduct + secondProduct, lhs.denominator * rhs.denominator);
        }

        // delegates to the == operator to check whether two Fractions Are Equal

        public static bool operator ==(Fraction lhs, Fraction rhs)
        {
           if (lhs.denominator == rhs.denominator && lhs.numerator == rhs.numerator)
            {
                return true;
            }
           // code is not working for 1/2 and 2/4 ( unlike fraction ) 
            return false;

        }

        // Check whether two Fractions Are Not Equal

        public static bool operator !=(Fraction lhs, Fraction rhs)
        {
            return !(lhs == rhs);
        }
        public override string ToString()
        {
            string s = numerator.ToString() + "/" + denominator.ToString();
            return s;
        }

    }
    public class Tester 
    {
       public void Run()
        {
            Fraction f1 = new Fraction(3, 4);
            Console.WriteLine("f1:{0}", f1.ToString());
            
            Fraction f2 = new Fraction(2, 4);
            Console.WriteLine("f2:{0}", f2.ToString());

            Fraction f3 = f1 + f2;

            Console.WriteLine("f1 + f2 = {0}", f3.ToString());

            Fraction f4 = new Fraction(5 ,4);

            if (f4 == f3)
            {
                Console.WriteLine("f4:{0} == f3:{1}", f4.ToString(), f3.ToString());

            }
            if (f4 != f2)
            {
                Console.WriteLine("f4:{0} != f2:{1}", f4.ToString(), f2.ToString());
            }

            if (f4.Equals(f3))
            {
                Console.WriteLine("f4:{0} Equals f3:{1}", f4.ToString(), f3.ToString());
            }
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
