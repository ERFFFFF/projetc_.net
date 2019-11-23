using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.net
{
    class DisplayConsole : IDisplay
    {
        WorkManager workManager = new WorkManager();

        public void DisplayChoices()
        {
            while (true)
            {
                // print choice of the user
                Console.Write("1. Create a new work \n" +
                    "2. Executa a work \n" +
                    "Enter the number of your choice : ");

                // read user input
                string choiceNewWork = Console.ReadLine();

                Console.WriteLine($"You made the {choiceNewWork} choice");

                // if the user type "1"
                if (choiceNewWork == "1")
                {
                    DisplayCreateNewWork();

                    // exit the loop (while)
                    break;
                }
                // if the user type "2"
                else if (choiceNewWork == "2")
                {
                    DisplayExecuteXWork();

                    // exit the loop (while)
                    break;
                }
            }
        }
        public void DisplayCreateNewWork()
        {
            string NameWork;
            string SaveType;
            string SourceDirectory;
            string TargetDirectory;
            do
            {
                Console.Write("Name of your work : ");
                NameWork = Console.ReadLine();

                Console.Write("Mirror save or Diferential save ? : ");
                SaveType = Console.ReadLine();

                Console.Write("Source Directory of your work : ");
                SourceDirectory = Console.ReadLine();

                Console.Write("Targeted Directory of your the work : ");
                TargetDirectory = Console.ReadLine();

                // call the method CreateNewWork
                workManager.createNewWork(NameWork, SaveType, SourceDirectory, TargetDirectory);
            }
            while (workManager.NoLoop == false);
        }
        public void DisplayExecuteXWork()
        {
            string ChooseWork;

            // call the ReadFile method in FileManager class

            // Display all the name of the work thanks to the method ReadFile
            Console.WriteLine("1. Name 1 \n" +
                "2. Namae 2 \n" +
                "3. Name 3 \n" +
                "4. Name 4 \n" +
                "5. Name 5");

            Console.Write("Which work do you want to execute ?");
            ChooseWork = Console.ReadLine();

            //call the method ExecuteXWork
            workManager.ExecuteXWork(ChooseWork);
        }
    }
}
