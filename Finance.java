import java.util.Scanner;
public class Finance {

    public static void main(String[] args) {
        Gmath gm = Gmath.getInstance();
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter 1. Nth root 2. Quadratic Eqn");
        int x = sc.nextInt();

        if (x == 1) {
            System.out.println("Enter num and n :");
            Double num = sc.nextDouble();
            Double n = sc.nextDouble();
            double root = gm.NthRoot(num, n);
            System.out.println("Square root of " + num + " is "+ root);

        } else if (x == 2){
            System.out.println("Enter a,b,c:");
            Double a = sc.nextDouble();
            Double b = sc.nextDouble();
            Double c = sc.nextDouble();
            double[] roots = gm.Quadratic(a, b, c); 
            System.out.println("Roots of the quadratic equation: " + roots[0] + ", " + roots[1]);
        } else {
            System.err.println("Invalid input");
        }

        sc.close();
    }

}

class Gmath {

    public double NthRoot(double num, double n) {
        return Math.pow(num, 1.0/n);
    }

    public double[] Quadratic(double a, double b, double c) {
        double displacement = b * b - 4 * a * c;
        if (displacement < 0.0) {
            return new double[] { Double.NaN, Double.NaN};
        } else  {
            double r1 = (-b + Math.sqrt(displacement)) / (2 * a);
            double r2 = (-b - Math.sqrt(displacement)) / (2 * a);
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
