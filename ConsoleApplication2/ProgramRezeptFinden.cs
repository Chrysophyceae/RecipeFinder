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
            rezeptErsterkuchen.SetName("Basiskuchen");
            rezeptErsterkuchen.SetZutatMehl(500);
            rezeptErsterkuchen.SetZutatZucker(100);
            rezeptErsterkuchen.SetZutatButter(100);
            rezeptErsterkuchen.SetZutatEier(4);

            RezeptModel rezeptZweiterkuchen = new RezeptModel();
            rezeptZweiterkuchen.SetName("Zweiter Kuchen");
            rezeptZweiterkuchen.SetZutatMehl(520);
            rezeptZweiterkuchen.SetZutatZucker(120);
            rezeptZweiterkuchen.SetZutatButter(120);
            rezeptZweiterkuchen.SetZutatEier(4);

            RezeptModel rezeptDritterkuchen = new RezeptModel();
            rezeptDritterkuchen.SetName("Dritter Kuchen");
            rezeptDritterkuchen.SetZutatMehl(250);
            rezeptDritterkuchen.SetZutatZucker(55);
            rezeptDritterkuchen.SetZutatButter(90);
            rezeptDritterkuchen.SetZutatEier(2);

            RezeptModel rezeptVierterkuchen = new RezeptModel();
            rezeptVierterkuchen.SetName("Vierter Kuchen");
            rezeptVierterkuchen.SetZutatMehl(400);
            rezeptVierterkuchen.SetZutatZucker(120);
            rezeptVierterkuchen.SetZutatButter(130);
            rezeptVierterkuchen.SetZutatEier(3);

            RezeptModel vorhandeneZutaten = new RezeptModel();
            vorhandeneZutaten.SetZutatMehl(400);
            vorhandeneZutaten.SetZutatZucker(120);
            vorhandeneZutaten.SetZutatButter(1130);
            vorhandeneZutaten.SetZutatEier(3);

           /* VergleichRezept(vorhandeneZutaten, rezeptErsterkuchen);
            VergleichRezept(vorhandeneZutaten, rezeptZweiterkuchen);
            VergleichRezept(vorhandeneZutaten, rezeptDritterkuchen);
            VergleichRezept(vorhandeneZutaten, rezeptVierterkuchen);*/

            Dictionary<string, RezeptModel> rezepte = new Dictionary<string, RezeptModel>(); // hier sind nur die gesamten rezepte drinnen, die über den namen angesprochen werden können. wir holen einfach alle der reihe nach. Die Zutaten sind halt fix

            /*rezepte.Add(rezeptErsterkuchen.GetName(), rezeptErsterkuchen);
            rezepte.Add(rezeptZweiterkuchen.GetName(), rezeptZweiterkuchen);
            rezepte.Add(rezeptDritterkuchen.GetName(), rezeptDritterkuchen);
            rezepte.Add(rezeptVierterkuchen.GetName(), rezeptVierterkuchen);*/

            AddRezept(rezepte, rezeptErsterkuchen); //übergibt Daten in dictionary
            AddRezept(rezepte, rezeptZweiterkuchen);
            AddRezept(rezepte, rezeptDritterkuchen);
            AddRezept(rezepte, rezeptVierterkuchen);


            foreach (var keyValueRezept in rezepte)
            {
                VergleichRezept(vorhandeneZutaten, keyValueRezept.Value);
            }
            Console.ReadKey();

        }


        private static void AddRezept(Dictionary<string, RezeptModel> rezepte, RezeptModel rezept)
        {
            rezepte.Add(rezept.GetName(), rezept); //rezeptname ist der key, value ist rezept. es ginge auch eine liste oder collection oder so, weil wir das rezpt zur zeit noch nicht mit namen ansprechen wollen
        }
   
        private static void VergleichRezept(RezeptModel vorhandeneZutaten, RezeptModel rezeptZutaten)
        {
            if (GenugZutaten(vorhandeneZutaten, rezeptZutaten))
            {
                Console.WriteLine("Genug Zutaten für dieses Rezept vorhanden:");
                AusgabeRezept(rezeptZutaten);
            }
            else
            {
                FehlendeZutaten(vorhandeneZutaten, rezeptZutaten);
            }
            }

        private static bool GenugZutaten(RezeptModel vorhandeneZutaten, RezeptModel rezeptZutaten)
        {
            if (vorhandeneZutaten.GetZutatMehl() < rezeptZutaten.GetZutatMehl()) { return false; }
            if (vorhandeneZutaten.GetZutatZucker() < rezeptZutaten.GetZutatZucker()) { return false; }
            if (vorhandeneZutaten.GetZutatButter() < rezeptZutaten.GetZutatButter()) { return false; }
            if (vorhandeneZutaten.GetZutatEier() < rezeptZutaten.GetZutatEier()) { return false; }

            return true;
        }

        private static void FehlendeZutaten(RezeptModel vorhandeneZutaten, RezeptModel rezeptZutaten)
        {
            string ausgabetext = "zu wenig ";
           
            if (vorhandeneZutaten.GetZutatMehl() < rezeptZutaten.GetZutatMehl()) { ausgabetext += "Mehl "; }
            if (vorhandeneZutaten.GetZutatZucker() < rezeptZutaten.GetZutatZucker()) { ausgabetext += "Zucker "; }
            if (vorhandeneZutaten.GetZutatButter() < rezeptZutaten.GetZutatButter()) { ausgabetext += "Butter "; }
            if (vorhandeneZutaten.GetZutatEier() < rezeptZutaten.GetZutatEier()) { ausgabetext += "Eier "; }

            Console.WriteLine(ausgabetext + "vorhanden für: "+ rezeptZutaten.GetName());
           
        }


        private static void AusgabeRezept(RezeptModel rezept)
        {

            Console.WriteLine(rezept.GetName());
            Console.WriteLine(rezept.GetZutatMehl() + " g Mehl");
            Console.WriteLine(rezept.GetZutatZucker() + " g Zucker");
            Console.WriteLine(rezept.GetZutatButter() + " g Butter");
            Console.WriteLine(rezept.GetZutatEier() + " Eier");
        }
    }
}



