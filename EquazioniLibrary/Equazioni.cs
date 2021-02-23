using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            if (a != 0)
                return true;
            return false;

        }
        public static bool IsInconsisted(double a, double b)
        {
            if (a == 0)
            {
                if (b != 0)
                    return true;
            }
            return false;
        }
        public static bool IsDegree2(double x)
        {
            if (x == 2)
                return true;
            return false;
        }
        public static double Delta(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            return delta;
        }
        public static string Result(double a, double b, double c)
        {
            
            double x1,x2;
            double delta = (b * b) - (4 * a * c);
             x1 = (-b + Math.Sqrt(delta)) / 2 * a;
             x2 = (-b - Math.Sqrt(delta)) / 2 * a;
            return ($"x1={x1} x2={x2}");
        }
        public static string EquationDegree1(double a, double b, double c)
        {
            string risultato = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    risultato = "Indeterminato";
                }
            }
            if (a != 0)
            {
                if (b == 0)
                {
                    risultato = "Impossibile";
                }
                else
                {
                    double x1, x2;
                    double delta = (b * b) - (4 * a * c);
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    return ($"x1={x1} x2={x2}");
                }
            }
                                                 
            return risultato;

        }

    }
}

