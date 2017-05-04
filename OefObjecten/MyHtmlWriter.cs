using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OefObjecten
{
    class MyHtmlWriter
    {
        public static void WritePersoonListToFile(
            string filename, 
            List<Persoon> personen,
            bool withStyle = true)
        {
            string contents = "";

            if(withStyle)
            {
                contents += "<style>";
                contents += "table { width: 80%; }";
                contents += "table, th, td { border: 1px solid black; }";
                contents += "th { font-weight: 700; background-color: gray; color: white }";
                contents += "</style>";
            }

            contents += "<table>";
            contents += "<tr><th>naam</th><th>leeftijd</th></tr>";

            foreach(var p in personen)
            {
                contents += "<tr>";
                contents += "<td>";
                contents += p.Naam;
                contents += "</td>";
                contents += "<td>";
                contents += p.Leeftijd;
                contents += "</td>";
                contents += "</tr>";
            }

            contents += "</table>";

            File.WriteAllText(filename, contents);
        }
    }
}
