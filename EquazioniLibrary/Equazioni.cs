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
            double b2 = b * b;
            double n = a * c;
            double n2 = n * 4;
            double delta = b2 - n2;
            return delta;
        }
    }
}
