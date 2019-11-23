using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.net
{
    class WorkManager
    {
        public bool NoLoop = true;

        public void createNewWork(string nameWork, string saveType, string sourceDirectory, string targetDirectory)
        {
            // verify the data
            //TODO  -> VERIFY THE GLOBAL PATH OF SOURCEDIRECTORY AND TARGETDIRECTORY
            if (nameWork != "" && (saveType == "Mirror" || saveType == "Diferential") && sourceDirectory != "" && targetDirectory != "")
            {
                NoLoop = true;
                Console.WriteLine("nameWork : " + nameWork);
                Console.WriteLine("saveType : " + saveType);
                Console.WriteLine("sourceDirectory : " + sourceDirectory);
                Console.WriteLine("targetDirectory : " + targetDirectory);
                
                // write data in a .txt file
            }
            else
            {
                Console.WriteLine("Error, Work not created. \n");
                NoLoop = false;
            }
        }
        public void ExecuteXWork(string chooseWork)
        {
            Console.WriteLine($"You choose to execute the work number {chooseWork}");
            
            //idk what to do next
        }

        
    }
}
