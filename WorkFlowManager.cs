using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.net
{
    class WorkFlowManager
    {
        DisplayConsole choice = new DisplayConsole();
        
        public void Choice()
        {
            int choices = choice.DisplayChoices();
            if (choices == 1)
            {
                choice.DisplayCreateNewWork();
            }
            else if(choices  == 2)
            {
                choice.DisplayExecuteXWork();
            }
        }
    }
}
