using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a, double b)
        {
            bool risposta = false;
            if (a != 0)
            {
                risposta = true;
            }

            return risposta;

        }
        public static bool IsInconsisted(double a, double b)
        {
            
            if (a == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsDegree2(double a)
        {
           
            if (a != 0)
            {
              return true;
            }
            return false;
        }
        public static double Delta(double a, double b, double c)
        {
            return (b * b) - 4 * a * c;

        }
        public static string EquationDegree1(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                return "Indeterminata";
            }
            if (a != 0 || b == 0)
            {
                return "Impossibile";
            }
            double risultato = -b / a;

            return risultato.ToString();
        }

    }
}
    
