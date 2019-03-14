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


        // metodo per vedere se impossible equazione
        static public bool IsInconsisted(double a,double b)
        {
            bool impossibile=false;

            if (a==0 && b!=0)
            {
                impossibile = true;

            }
          
           

            return impossibile;
        }



        // metodo per vedere se indeterminata equazione
        static public bool indeterminata(double a, double b)
        {

            bool indeterminata  = false;

          
            if (a == 0 && b == 0)
            {
                indeterminata = true;
            }


            return indeterminata;
        }


        //controla se equazione è di secondo grado
        static public bool  Isdegree2(double a)
        {
            bool controllo = false;


            if (a != 0 )
            {
                controllo = true;
            }


            return controllo;
        }



        //calcolo delta 
        static public double Delta(double a,double b,double c)
        {
            double calcolo = (b * b) - 4 * a * c;
            
            return calcolo;
            
        }




        static public string EquationDegree(double a, double b)
        {
            string resultato = "";
            if(indeterminata (a,  b)==true) resultato = "Indeterminato";
            if(IsInconsisted( a, b)==true) resultato = "Impossibile";
           
           
            if(resultato=="")
            {
                resultato = $"x={-b/a}";
                

            }

            return resultato;
        }
    }
}
