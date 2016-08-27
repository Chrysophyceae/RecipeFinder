using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Controller
{
    class PrintController
    {
       public AusgabeZutatenlisteComponent ausgabeZutatenlisteComponent { get; }
        public PrintListComponent printListComponent { get; }

        public PrintController()
        {
            ausgabeZutatenlisteComponent = new AusgabeZutatenlisteComponent();
            printListComponent = new PrintListComponent();
        }

        
    }
}
