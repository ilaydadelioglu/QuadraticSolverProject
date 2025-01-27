using System;

namespace QuadraticEquationSolver
{
    public static class QuadraticSolver
    {
        public static (double[], string) Solve(double a, double b, double c)
        {
            // Eğer a == 0 ise bu bir ikinci dereceden denklem değil
            if (a == 0)
            {
                return (new double[0], "Not a quadratic equation.");
            }

            // Diskriminant hesapla (b^2 - 4ac)
            double discriminant = b * b - 4 * a * c;

            // Eğer diskriminant negatifse, reel kök yok
            if (discriminant < 0)
            {
                return (new double[0], "No real roots.");
            }

            // Eğer diskriminant sıfırsa, bir gerçek kök var
            if (discriminant == 0)
            {
                return (new double[] { -b / (2 * a) }, "One real root.");
            }

            // Eğer diskriminant pozitifse, iki gerçek kök var
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return (new double[] { root1, root2 }, "Two real roots.");
        }
    }
}
