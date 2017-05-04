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
            var personen = new List<Persoon>();

            var p1 = new Persoon { Naam = "Joske", Leeftijd = 13 };
            personen.Add(p1);

            var p2 = new Persoon();
            p2.Naam = "Jantje";
            p2.Leeftijd = 14;
            personen.Add(p2);

            var p3 = new Persoon("Mieke", 15);
            personen.Add(p3);
                
            foreach(var p in personen)
            {
                Console.WriteLine(p.Naam + " is " + p.Leeftijd);
            }

            MyHtmlWriter.WritePersoonListToFile("personen.html", personen);
        }
    }
}
