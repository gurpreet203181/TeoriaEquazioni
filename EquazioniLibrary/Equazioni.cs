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
    }
}
