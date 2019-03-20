using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        static public bool Determinato(Double a)
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
        static public bool Impossible(double a,double b)
        {
            bool impossibile=false;

            if (a==0 && b!=0)
            {
                impossibile = true;

            }
          
           

            return impossibile;
        }



        // metodo per vedere se indeterminata equazione
        static public bool Indeterminato(double a, double b)
        {

            bool indeterminato  = false;

          
            if (a == 0 && b == 0)
            {
                indeterminato = true;
            }


            return indeterminato;
        }


        //controla se equazione è di secondo grado
        static public bool  Controlo(double a)
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




        static public string Equazione(double a, double b)
        {
            string risultato = "";
            if(Indeterminato(a,  b)==true) risultato = "Indeterminato";
            if(Impossible( a, b)==true) risultato = "Impossibile";
           
           
            if(risultato=="")
            {
                risultato = $"x={-b/a}";
                

            }

            return risultato;
        }
    }
}

