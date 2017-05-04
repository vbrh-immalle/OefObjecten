using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefObjecten
{
    class Program
    {
        static void Main(string[] args)
        {
            var personen = new List<Persoon>()
            {
                new Persoon { Naam = "Joske", Leeftijd = 13 },
                new Persoon { Naam = "Jantje", Leeftijd = 14 },
                new Persoon { Naam = "Mieke", Leeftijd = 15 }
            };

            foreach(var p in personen)
            {
                Console.WriteLine(p.Naam + " is " + p.Leeftijd);
            }
        }
    }
}
