using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class RezeptModel
    {
        
        string rezeptname = "Rezept ohne Namen";

        Dictionary<string, int> zutatenliste = new Dictionary<string, int>();

        public void SetZutatenliste(Dictionary<string, int> zutatenlisteEingegeben)
        {
            zutatenliste = zutatenlisteEingegeben;
        }


        public void SetName(string rezeptNameEingegeben)
        {
            rezeptname = rezeptNameEingegeben;
        }

        
        public Dictionary<string, int> GetZutatenliste()
        {
            return zutatenliste;
        }


        public string GetName()
        {
            return rezeptname;
        }


    }
}
