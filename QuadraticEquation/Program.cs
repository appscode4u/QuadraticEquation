using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(QuadraticEquation.SolveQuadraticEquation(2,3,4));
            Console.ReadKey();
        }
    }

    public class QuadraticEquation
    {
        public static int SolveQuadraticEquation(int a, int b, int c)
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
                return -1;
            }
            
        }
    }
}
