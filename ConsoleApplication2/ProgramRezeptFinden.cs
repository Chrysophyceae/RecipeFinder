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
        public static PrintController printController = new PrintController();

        static void Main(string[] args)
        {
            RezeptFinder rezeptFinder = new RezeptFinder();
            rezeptFinder.start();
            Console.ReadKey();
        }
    }
}



