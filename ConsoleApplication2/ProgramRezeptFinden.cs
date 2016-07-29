using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            
                        RezeptModel rezeptErsterkuchen = new RezeptModel();
            rezeptErsterkuchen.SetName(" Erster Kuchen");
            Dictionary<string, int> zutatenlisteErsterKuchen = new Dictionary<string, int>();
            zutatenlisteErsterKuchen.Add("Mehl", 500);
            zutatenlisteErsterKuchen.Add("Zucker", 100);
            zutatenlisteErsterKuchen.Add("Butter", 100);
            zutatenlisteErsterKuchen.Add("Eier", 4);
            rezeptErsterkuchen.SetZutatenliste(zutatenlisteErsterKuchen);
            
            RezeptModel rezeptZweiterkuchen = new RezeptModel();
            rezeptZweiterkuchen.SetName("Zweiter Kuchen");
            Dictionary<string, int> zutatenlisteZweiterKuchen = new Dictionary<string, int>();
            zutatenlisteZweiterKuchen.Add("Mehl", 520);
            zutatenlisteZweiterKuchen.Add("Zucker", 120);
            zutatenlisteZweiterKuchen.Add("Butter", 120);
            zutatenlisteZweiterKuchen.Add("Eier", 4);
            rezeptZweiterkuchen.SetZutatenliste(zutatenlisteZweiterKuchen);

            RezeptModel rezeptDritterkuchen = new RezeptModel();
            rezeptDritterkuchen.SetName("Dritter Kuchen");
            Dictionary<string, int> zutatenlisteDritterKuchen = new Dictionary<string, int>();
            zutatenlisteDritterKuchen.Add("Mehl", 250);
            zutatenlisteDritterKuchen.Add("Zucker", 55);
            zutatenlisteDritterKuchen.Add("Butter", 90);
            zutatenlisteDritterKuchen.Add("Eier", 2);
            rezeptDritterkuchen.SetZutatenliste(zutatenlisteDritterKuchen);

            RezeptModel rezeptVierterkuchen = new RezeptModel();
            rezeptVierterkuchen.SetName("Vierter Kuchen");
                 Dictionary<string, int> zutatenlisteVierterKuchen = new Dictionary<string, int>();
                zutatenlisteVierterKuchen.Add("Mehl", 400);
                zutatenlisteVierterKuchen.Add("Zucker", 120);
                zutatenlisteVierterKuchen.Add("Butter", 130);
                zutatenlisteVierterKuchen.Add("Eier", 3);
            rezeptVierterkuchen.SetZutatenliste(zutatenlisteVierterKuchen);

            RezeptModel rezeptFuenfterKuchen = new RezeptModel();
            rezeptFuenfterKuchen.SetName("Fuenfter Kuchen");
                Dictionary<string, int> zutatenlisteFuenfterKuchen = new Dictionary<string, int>();
                zutatenlisteFuenfterKuchen.Add("Mehl", 500);
                zutatenlisteFuenfterKuchen.Add("Zucker", 100);
                zutatenlisteFuenfterKuchen.Add("Butter", 100);
                zutatenlisteFuenfterKuchen.Add("Eier", 4);
                zutatenlisteFuenfterKuchen.Add("Nüsse", 50);
            rezeptFuenfterKuchen.SetZutatenliste(zutatenlisteFuenfterKuchen);
            

            RezeptModel vorhandeneZutaten = new RezeptModel();
            vorhandeneZutaten.SetName("Eingegebene Zutaten");
            Dictionary<string, int> zutatenlisteVorhandeneZutaten = new Dictionary<string, int>();
            zutatenlisteVorhandeneZutaten.Add("Mehl", 400);
            zutatenlisteVorhandeneZutaten.Add("Zucker", 120);
            zutatenlisteVorhandeneZutaten.Add("Butter", 1130);
            zutatenlisteVorhandeneZutaten.Add("Eier", 3);
            vorhandeneZutaten.SetZutatenliste(zutatenlisteVorhandeneZutaten);

            Dictionary<string, RezeptModel> rezepte = new Dictionary<string, RezeptModel>();
           
            AddRezept(rezepte, rezeptErsterkuchen); 
            AddRezept(rezepte, rezeptZweiterkuchen);
            AddRezept(rezepte, rezeptDritterkuchen);
            AddRezept(rezepte, rezeptVierterkuchen);
            AddRezept(rezepte, rezeptFuenfterKuchen);

           
           foreach (KeyValuePair<string, RezeptModel> keyValueRezept in rezepte)
            {
                VergleichRezept(vorhandeneZutaten, keyValueRezept.Value);
            }

            Console.ReadKey();

        }



        private static void AusgabeZutatenliste(RezeptModel rezept)
        {
            Console.WriteLine("Zutatenliste für" + rezept.GetName());

            foreach (KeyValuePair<string, int> zutat in rezept.GetZutatenliste())
            {
                Console.WriteLine(zutat.Value + " , " + zutat.Key);
            }
        }

       

    private static void AddRezept(Dictionary<string, RezeptModel> rezepte, RezeptModel rezept)
        {
            rezepte.Add(rezept.GetName(), rezept);
        }
   

        private static void VergleichRezept(RezeptModel vorhandeneZutaten, RezeptModel rezeptZutaten)
        {
            if (GenugZutaten(vorhandeneZutaten, rezeptZutaten))
            {
                Console.WriteLine("Genug Zutaten für dieses Rezept vorhanden:");
                AusgabeZutatenliste(rezeptZutaten);
            }
            else
                {
                FehlendeZutaten(vorhandeneZutaten, rezeptZutaten);
                }
            }

        private static bool GenugZutaten(RezeptModel vorhandeneZutaten, RezeptModel rezeptZutaten)
        {
            //if (vorhandeneZutaten.GetZutatMehl() < rezeptZutaten.GetZutatMehl()) { return false; }
            //if (vorhandeneZutaten.GetZutatZucker() < rezeptZutaten.GetZutatZucker()) { return false; }
            //if (vorhandeneZutaten.GetZutatButter() < rezeptZutaten.GetZutatButter()) { return false; }
            //if (vorhandeneZutaten.GetZutatEier() < rezeptZutaten.GetZutatEier()) { return false; }

            foreach (KeyValuePair<string, int> zutat in rezeptZutaten.GetZutatenliste())
            {
                Dictionary<string, int> vorhandeneZutatenliste = vorhandeneZutaten.GetZutatenliste();
                Console.WriteLine("prüfung "+zutat.Value + " , " + zutat.Key);
                 if (vorhandeneZutatenliste.ContainsKey(zutat.Key))
                    { Console.WriteLine(zutat.Value + " vorhanden");
                    int vorhandeneZutat = vorhandeneZutatenliste[zutat.Key]; ;
                    int rezeptZutat = zutat.Value;
                    if (vorhandeneZutat< rezeptZutat) { return false; }
                        }
                 
                
                  }


            return true;
        }



        private static void FehlendeZutaten(RezeptModel vorhandeneZutaten, RezeptModel rezeptZutaten)
        {
            string ausgabetext = "zu wenig ";

            //if (vorhandeneZutaten.GetZutatMehl() < rezeptZutaten.GetZutatMehl()) { ausgabetext += "Mehl "; }
            //if (vorhandeneZutaten.GetZutatZucker() < rezeptZutaten.GetZutatZucker()) { ausgabetext += "Zucker "; }
            //if (vorhandeneZutaten.GetZutatButter() < rezeptZutaten.GetZutatButter()) { ausgabetext += "Butter "; }
            //if (vorhandeneZutaten.GetZutatEier() < rezeptZutaten.GetZutatEier()) { ausgabetext += "Eier "; }

            Console.WriteLine(ausgabetext + "vorhanden für: "+ rezeptZutaten.GetName());
           
        }


       
    }
}



