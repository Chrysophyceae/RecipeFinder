using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Controller
{
    class AusgabeZutatenlisteComponent
    {
        public void AusgabeZutatenliste(RezeptModel rezept)
        {
            Console.WriteLine("Zutatenliste für" + rezept.rezeptname);

            foreach (KeyValuePair<string, int> zutat in rezept.zutatenliste)
            {
                Console.WriteLine(zutat.Value + " , " + zutat.Key);
            }
        }
    }
}
