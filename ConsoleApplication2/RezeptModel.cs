using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class RezeptModel
    {
        int MehlinGramm = 0;
        int ZuckerinGramm = 0;
        int ButterinGramm = 0;
        int EierStueck = 0;
        string rezeptname = "Rezept ohne Namen";

        public void SetName(string RezeptNameEingegeben)
        {
            rezeptname = RezeptNameEingegeben;
        }

        public void SetZutatMehl(int MehlVorhanden)
        {
           MehlinGramm = MehlVorhanden;
        }

        public void SetZutatZucker(int ZuckerVorhanden)
        {
            ZuckerinGramm = ZuckerVorhanden;
        }

        public void SetZutatButter(int ButterVorhanden)
        {
            ButterinGramm = ButterVorhanden;
        }

        public void SetZutatEier(int EierVorhanden)
        {
            EierStueck = EierVorhanden;
        }

        public string GetName()
        {
            return rezeptname;
        }

        public int GetZutatMehl()
        {
            return MehlinGramm;
        }

        public int GetZutatZucker()
        {
            return ZuckerinGramm;
        }

        public int GetZutatButter()
        {
            return ButterinGramm;
        }

        public int GetZutatEier()
        {
            return EierStueck;
        }
    }
}
