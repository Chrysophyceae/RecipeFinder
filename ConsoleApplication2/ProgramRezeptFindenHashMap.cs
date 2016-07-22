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

            RezeptModel rezeptBasiskuchen = new RezeptModel();
            rezeptBasiskuchen.SetName("Basiskuchen");
            rezeptBasiskuchen.SetZutatMehl(500);
            rezeptBasiskuchen.SetZutatZucker(100);
            rezeptBasiskuchen.SetZutatButter(100);
            rezeptBasiskuchen.SetZutatEier(4);

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

            VergleichRezept(vorhandeneZutaten, rezeptBasiskuchen);
            VergleichRezept(vorhandeneZutaten, rezeptZweiterkuchen);
            VergleichRezept(vorhandeneZutaten, rezeptDritterkuchen);
            VergleichRezept(vorhandeneZutaten, rezeptVierterkuchen);

            // Create a HashMap with three key/value pairs.
            HashMap hm = new HashMap();
            hm.put("One", "1");
            hm.put("Two", "2a");
            hm.put("Two", "2b");
            hm.put("Three", "3");

            // Iterate over the HashMap to see what we just put in.
            Set set = hm.entrySet();
            Iterator setIter = set.iterator();
            while (setIter.hasNext())
            {
                System.out.println(setIter.next());
            }

            Console.ReadKey();

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



