using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controller
{
    class PrintListComponent
    {
        public void PrintList()
        {
            var profenFiles = new List<Filestatusmodel>();
            Filestatusmodel file1 = new Filestatusmodel();
            Filestatusmodel file2 = new Filestatusmodel();
            file1.Status = true;
            file2.Status = false;
            file1.Name = "Datei1";
            file2.Name = "Datei2";

            profenFiles.Add(file1);
            profenFiles.Add(file2);

            foreach (Filestatusmodel filestatus in profenFiles)
            {
                Console.WriteLine(filestatus.Name);
            }

        }

    }
}
