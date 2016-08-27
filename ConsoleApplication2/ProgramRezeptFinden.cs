using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;


namespace MainProgram
{
    class Program
    {
        //PrintController printController = new PrintController();
        static void Main(string[] args)
        {


            RezeptModel rezeptErsterkuchen = new RezeptModel();
            rezeptErsterkuchen.rezeptname = " Erster Kuchen";
            Dictionary<string, int> zutatenlisteErsterKuchen = new Dictionary<string, int>();
            zutatenlisteErsterKuchen.Add("Mehl", 500);
            zutatenlisteErsterKuchen.Add("Zucker", 100);
            zutatenlisteErsterKuchen.Add("Butter", 100);
            zutatenlisteErsterKuchen.Add("Eier", 4);
            rezeptErsterkuchen.zutatenliste = zutatenlisteErsterKuchen;

            RezeptModel rezeptZweiterkuchen = new RezeptModel();
            rezeptZweiterkuchen.rezeptname = "Zweiter Kuchen";
            Dictionary<string, int> zutatenlisteZweiterKuchen = new Dictionary<string, int>();
            zutatenlisteZweiterKuchen.Add("Mehl", 520);
            zutatenlisteZweiterKuchen.Add("Zucker", 120);
            zutatenlisteZweiterKuchen.Add("Butter", 120);
            zutatenlisteZweiterKuchen.Add("Eier", 4);
            rezeptZweiterkuchen.zutatenliste = zutatenlisteZweiterKuchen;

            RezeptModel rezeptDritterkuchen = new RezeptModel();
            rezeptDritterkuchen.rezeptname = "Dritter Kuchen";
            Dictionary<string, int> zutatenlisteDritterKuchen = new Dictionary<string, int>();
            zutatenlisteDritterKuchen.Add("Mehl", 250);
            zutatenlisteDritterKuchen.Add("Zucker", 55);
            zutatenlisteDritterKuchen.Add("Butter", 90);
            zutatenlisteDritterKuchen.Add("Eier", 2);
            rezeptDritterkuchen.zutatenliste = zutatenlisteDritterKuchen;

            RezeptModel rezeptVierterkuchen = new RezeptModel();
            rezeptVierterkuchen.rezeptname = "Vierter Kuchen";
            Dictionary<string, int> zutatenlisteVierterKuchen = new Dictionary<string, int>();
            zutatenlisteVierterKuchen.Add("Mehl", 400);
            zutatenlisteVierterKuchen.Add("Zucker", 120);
            zutatenlisteVierterKuchen.Add("Butter", 130);
            zutatenlisteVierterKuchen.Add("Eier", 3);
            rezeptVierterkuchen.zutatenliste = zutatenlisteVierterKuchen;

            RezeptModel rezeptFuenfterKuchen = new RezeptModel();
            rezeptFuenfterKuchen.rezeptname = "Fuenfter Kuchen";
            Dictionary<string, int> zutatenlisteFuenfterKuchen = new Dictionary<string, int>();
            zutatenlisteFuenfterKuchen.Add("Mehl", 500);
            zutatenlisteFuenfterKuchen.Add("Zucker", 100);
            zutatenlisteFuenfterKuchen.Add("Butter", 100);
            zutatenlisteFuenfterKuchen.Add("Eier", 4);
            zutatenlisteFuenfterKuchen.Add("Nüsse", 50);
            rezeptFuenfterKuchen.zutatenliste = zutatenlisteFuenfterKuchen;

            RezeptModel vorhandeneZutaten = new RezeptModel();
            vorhandeneZutaten.rezeptname = "Eingegebene Zutaten";
            Dictionary<string, int> zutatenlisteVorhandeneZutaten = new Dictionary<string, int>();
            zutatenlisteVorhandeneZutaten.Add("Mehl", 400);
            zutatenlisteVorhandeneZutaten.Add("Zucker", 120);
            zutatenlisteVorhandeneZutaten.Add("Butter", 1130);
            zutatenlisteVorhandeneZutaten.Add("Eier", 3);
            vorhandeneZutaten.zutatenliste = zutatenlisteVorhandeneZutaten;

            List<RezeptModel> rezeptaufzaehlung = new List<RezeptModel>();

            rezeptaufzaehlung.Add(rezeptErsterkuchen);
            rezeptaufzaehlung.Add(rezeptZweiterkuchen);
            rezeptaufzaehlung.Add(rezeptDritterkuchen);
            rezeptaufzaehlung.Add(rezeptVierterkuchen);
            rezeptaufzaehlung.Add(rezeptFuenfterKuchen);

            foreach (RezeptModel rezeptInList in rezeptaufzaehlung)
            {
                Console.WriteLine("-------------");
                VergleichRezept(vorhandeneZutaten, rezeptInList);
            }


            PrintController printController = new PrintController();
            printController.printListComponent.PrintList();



            Console.ReadKey();
        }

       


        private static void VergleichRezept(RezeptModel vorhandeneZutaten, RezeptModel rezeptZutaten)
        {
            if (GenugZutaten(vorhandeneZutaten, rezeptZutaten))
            {
                Console.WriteLine("Genug Zutaten für dieses Rezept vorhanden:");
                PrintController printController = new PrintController();
                printController.ausgabeZutatenlisteComponent.AusgabeZutatenliste(rezeptZutaten);
               
            }
            else
            {
                FehlendeZutaten(vorhandeneZutaten, rezeptZutaten);
            }
        }

        private static bool GenugZutaten(RezeptModel vorhandeneZutaten, RezeptModel rezeptZutaten)
        {
            foreach (KeyValuePair<string, int> zutat in rezeptZutaten.zutatenliste)
            {
                if (vorhandeneZutaten.zutatenliste.ContainsKey(zutat.Key))
                {
                    int vorhandeneZutat = vorhandeneZutaten.zutatenliste[zutat.Key]; ;
                    int rezeptZutat = zutat.Value;
                    if (vorhandeneZutat < rezeptZutat) { return false; }
                }
            }
            return true;
        }

        private static void FehlendeZutaten(RezeptModel vorhandeneZutaten, RezeptModel rezeptZutaten)
        {
            string ausgabetext = "zu wenig ";

            Console.WriteLine(ausgabetext + "vorhanden für: " + rezeptZutaten.rezeptname);
        }

    }
}



