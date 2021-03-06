﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bilek_Mechanni_Autoverleih
{
    class Person
    {
        private int kundenNr;
        private String vorname;
        private String nachname;
        private String telNr;
        private String anrede;
        private String adresse;

        public Person(int kundenNr, String vorname, String nachname, String telNr, String anrede, String adresse)
        {
            KundenNr = kundenNr;
            Vorname = vorname;
            Nachname = nachname;
            TelNr = telNr;
            Anrede = anrede;
            Adresse = adresse;
        }
        public int KundenNr
        {
            get
            {
                return kundenNr;
            }

            set
            {
                kundenNr = value;
            }
        }

        

        public string TelNr
        {
            get
            {
                return telNr;
            }

            set
            {
                telNr = value;
            }
        }

        public string Anrede
        {
            get
            {
                return anrede;
            }

            set
            {
                anrede = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                vorname = value;
            }
        }

        public string Nachname
        {
            get
            {
                return nachname;
            }

            set
            {
                nachname = value;
            }
        }
    }
}
