﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefObjecten
{
    class Persoon
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public Persoon()
        {

        }

        public Persoon(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }
    }
}
