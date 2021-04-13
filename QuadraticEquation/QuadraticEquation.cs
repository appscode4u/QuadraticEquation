using System;

namespace QuadraticEquation
{
    public class Program
    {
        public static void Main()
        {

        }
    }
    public class QuadraticEquationCalculation
    {
        public QuadraticEquationCalculation() {}

        public int CalculateNumberOfRoots(double a, double b, double c)
        {

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                try{
                    double deltaSqrt = Math.Sqrt(delta);
                    var x1 = (-b + deltaSqrt) / (2 * a);
                    var x2 = (-b - deltaSqrt) / (2 * a);

                    return 2;
                }
                catch { return -1;}
            }
            else if (delta == 0)
            {
                var x = -b / (2 * a);
                return 1;
            }
            else
            {//delta <0 so we should calculate roots for complex numbers
                double deltaSqrt = Math.Sqrt(Math.Abs(delta));
                var A = -b / (2 * a);
                var B = deltaSqrt / (2 * A);
                string aPlusBi = A + "+" + B + "i";
                string aMinusBi = A + "-" + B + "i";
                string txt = aPlusBi + " " + aMinusBi;
                return 0; //because task was only for real numbers, so we will return count of 0
            }
            
        }
    }
}
