using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace ØresundBillet
{
   public class MC : Køretøj
    {
        public override string Køretøjet()
        {
            return "Øresund MC";
        }

        public override decimal Pris(bool brobizz)
        {
            if (brobizz)
            {
                return 73;
            }

            return 210;
        }
    }
}
