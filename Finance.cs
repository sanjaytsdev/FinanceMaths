using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance
{
    public class Finance
    {
        public static void Main(String[] args) {
            Gmath gm = Gmath.getInstance();

            Console.WriteLine("Enter 1. Nth root 2. Quadratic Eqn");
            string input = Console.ReadLine();
            int x = int.Parse(input);

            if (x == 1) {
                Console.WriteLine("Enter num and n :");
                string value = Console.ReadLine();
                string data = Console.ReadLine();
                double num = double.Parse(value);
                double n = double.Parse(data);
                double root = gm.NthRoot(num, n);
                Console.WriteLine("Square root of {0} is {1}", num, root);

            } else if (x == 2){
                Console.WriteLine("Enter a,b,c:");
                string value1 = Console.ReadLine();
                string data1 = Console.ReadLine();
                string input1 = Console.ReadLine();
                double a = double.Parse(value1);
                double b = double.Parse(data1);
                double c = double.Parse(input1);
                double[] roots = gm.Quadratic(a, b, c); 
                Console.WriteLine("Roots of the quadratic equation: {0} {1}", roots[0], roots[1]);
            }
        
        }
    }

    public class Gmath {
        public double NthRoot(double num, double n) {
            return Math.Pow(num, 1.0/n);
       }

        public double[] Quadratic(double a, double b, double c) {
            double displacement = b * b - 4 * a * c;
            if (displacement < 0.0) {
                return new double[] { Double.NaN, Double.NaN};
            } else  {
                double r1 = (-b + Math.Sqrt(displacement)) / (2 * a);
                double r2 = (-b - Math.Sqrt(displacement)) / (2 * a);
                return new double[] {r1, r2};
            }
        }

        private static Gmath g = null;

        private Gmath() {

        }

        public static Gmath getInstance() {
            if (g == null) {
                g = new Gmath();
            }
            return g;
        }

        private static Gmath createInstance() {
            return Gmath.getInstance();
        }
    }
}