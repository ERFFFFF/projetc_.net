using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.net
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayConsole disp = new DisplayConsole();
            disp.DisplayChoices();
            Console.ReadLine();
        }
    }
}
