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
            WorkFlowManager workflow = new WorkFlowManager();
            workflow.Choice();
            Console.ReadLine();
        }
    }
}
