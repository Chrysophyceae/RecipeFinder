using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class RezeptModel
    {
        int mehlinGramm = 0;
        int zuckerinGramm = 0;
        int butterinGramm = 0;
        int eierStueck = 0;
        string rezeptname = "Rezept ohne Namen";

        public void SetName(string rezeptNameEingegeben)
        {
            rezeptname = rezeptNameEingegeben;
        }

        public void SetZutatMehl(int mehlVorhanden)
        {
           mehlinGramm = mehlVorhanden;
        }

        public void SetZutatZucker(int zuckerVorhanden)
        {
            zuckerinGramm = zuckerVorhanden;
        }

        public void SetZutatButter(int butterVorhanden)
        {
            butterinGramm = butterVorhanden;
        }

        public void SetZutatEier(int eierVorhanden)
        {
            eierStueck = eierVorhanden;
        }

        public string GetName()
        {
            return rezeptname;
        }

        public int GetZutatMehl()
        {
            return mehlinGramm;
        }

        public int GetZutatZucker()
        {
            return zuckerinGramm;
        }

        public int GetZutatButter()
        {
            return butterinGramm;
        }

        public int GetZutatEier()
        {
            return eierStueck;
        }
    }
}
