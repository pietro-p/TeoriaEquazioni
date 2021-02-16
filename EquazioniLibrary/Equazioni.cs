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
    }
}
