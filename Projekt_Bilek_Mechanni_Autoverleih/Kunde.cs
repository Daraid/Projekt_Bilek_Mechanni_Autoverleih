﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bilek_Mechanni_Autoverleih
{
    class Kunde : Person
    {
        private List<Fahrzeug> interesse;
        public Kunde(int kundenNr, string vorname, string nachname, string telNr, string anrede, string adresse, List<Fahrzeug> interesse) : base(kundenNr, vorname, nachname, telNr, anrede, adresse)
        {
            Interesse = interesse;
        }

        internal List<Fahrzeug> Interesse
        {
            get
            {
                return interesse;
            }

            set
            {
                interesse = value;
            }
        }
    }
}
