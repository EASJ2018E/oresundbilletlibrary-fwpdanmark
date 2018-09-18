using System;
using BilletLibrary;

namespace ØresundBillet
{
    public class Bil : Køretøj
    {
        public override string Køretøjet()
        {
            return "Øresund Bil";
        }

        public override decimal Pris(bool brobizz)
        {
            if (brobizz)
            {
                return 161m;
            }

            return 410;

        }
    }
}
