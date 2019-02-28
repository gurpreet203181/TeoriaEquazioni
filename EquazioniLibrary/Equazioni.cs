using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        static public bool IsDetermined(Double a)
        {
            bool determinato;
            if(a!=0)
            {
                determinato = true;

            }
            else
            {
                determinato = false;
            }

            return determinato;

        }


        static public bool IsInconsisted(double a,double b)
        {
            bool impossibile=false;

            if (a==0 && b!=0)
            {
                impossibile = true;

            }
          
           

            return impossibile;
        }
        static public bool indeterminata(double a, double b)
        {
            bool impossibile=false;

          
            if (a == 0 && b == 0)
            {
                impossibile = true;
            }


            return impossibile;
        }
        static public bool  Isdegree2(double a)
        {
            bool controllo = false;


            if (a != 0 )
            {
                controllo = true;
            }


            return controllo;
        }

        static public double Delta(double a,double b,double c)
        {
            double calcolo = (b * b) - 4 * a * c;
            
            return calcolo;
            
        }
    }
}
