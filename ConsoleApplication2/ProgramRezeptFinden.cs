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

            RezeptModel RezeptBasiskuchen = new RezeptModel();
            RezeptBasiskuchen.SetName("Basiskuchen");
            RezeptBasiskuchen.SetZutatMehl(500);
            RezeptBasiskuchen.SetZutatZucker(100);
            RezeptBasiskuchen.SetZutatButter(100);
            RezeptBasiskuchen.SetZutatEier(4);

            RezeptModel RezeptZweiterkuchen = new RezeptModel();
            RezeptZweiterkuchen.SetName("Zweiter Kuchen");
            RezeptZweiterkuchen.SetZutatMehl(520);
            RezeptZweiterkuchen.SetZutatZucker(120);
            RezeptZweiterkuchen.SetZutatButter(120);
            RezeptZweiterkuchen.SetZutatEier(4);

            RezeptModel RezeptDritterkuchen = new RezeptModel();
            RezeptDritterkuchen.SetName("Dritter Kuchen");
            RezeptDritterkuchen.SetZutatMehl(250);
            RezeptDritterkuchen.SetZutatZucker(55);
            RezeptDritterkuchen.SetZutatButter(90);
            RezeptDritterkuchen.SetZutatEier(2);

            RezeptModel RezeptVierterkuchen = new RezeptModel();
            RezeptVierterkuchen.SetName("Vierter Kuchen");
            RezeptVierterkuchen.SetZutatMehl(400);
            RezeptVierterkuchen.SetZutatZucker(120);
            RezeptVierterkuchen.SetZutatButter(130);
            RezeptVierterkuchen.SetZutatEier(3);

            RezeptModel VorhandeneZutaten = new RezeptModel();
            VorhandeneZutaten.SetZutatMehl(400);
            VorhandeneZutaten.SetZutatZucker(120);
            VorhandeneZutaten.SetZutatButter(130);
            VorhandeneZutaten.SetZutatEier(3);

            Console.WriteLine("Vergleich mit" + VergleichEingabemitRezept(VorhandeneZutaten, RezeptZweiterkuchen));
            Console.WriteLine("Vergleich Dritter Kuchen" + VergleichEingabemitRezept(VorhandeneZutaten, RezeptDritterkuchen));

            Console.WriteLine(RezeptZweiterkuchen.GetName());
            Console.WriteLine(RezeptZweiterkuchen.GetZutatMehl() + " g Mehl");
            Console.WriteLine(RezeptZweiterkuchen.GetZutatZucker() + " g Zucker");
            Console.WriteLine(RezeptZweiterkuchen.GetZutatButter() + " g Butter");
            Console.WriteLine(RezeptZweiterkuchen.GetZutatEier() + " Eier");


            Console.ReadKey();



        }

        private static string VergleichEingabemitRezept(RezeptModel a, RezeptModel b)
        {
            string ausgabetext = "zu wenig ";
            bool zuwenig = false;

            if (a.GetZutatMehl() < b.GetZutatMehl()) { ausgabetext += "Mehl "; zuwenig = true; }
            if (a.GetZutatZucker() < b.GetZutatZucker()) { ausgabetext += "Zucker "; zuwenig = true; }
            if (a.GetZutatButter() < b.GetZutatButter()) { ausgabetext += "Butter "; zuwenig = true; }
            if (a.GetZutatEier() < b.GetZutatEier()) { ausgabetext += "Eier "; zuwenig = true; }

            if (zuwenig) { return ausgabetext + "vorhanden"; };

            return "genug Zutaten vorhanden für folgendes Rezept:";

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



