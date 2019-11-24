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

        public int DisplayChoices()
        {
            while (true)
            {
                // print choice of the user
                Console.Write("1. Create a new work \n" +
                    "2. Execute a work \n" +
                    "Enter the number of your choice : ");

                // read user input
                string choiceNewWork = Console.ReadLine();
                int y = 0;
                // convert string to int
                if (Int32.TryParse(choiceNewWork, out y))
                {
                    //if the user type "1"
                    if (y == 1)
                    {
                        return 1;
                    }
                    // if the user type "2"
                    else if (y == 2)
                    {
                        return 2;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct value.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a correct value.");
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
        public List<int> DisplayExecuteXWork()
        {
            List<int> ListExecuteWork = new List<int>();
            string ChooseWork;
            string AnotherWork;
            bool choiceExecute = true;
            bool numberchoice = true;
            bool ChoiceAnotherWord = true;
            // call the ReadFile method in FileManager class


            // Display all the name of the work thanks to the method ReadFile
            Console.WriteLine("1. Name 1 \n" +
                "2. Name 2 \n" +
                "3. Name 3 \n" +
                "4. Name 4 \n" +
                "5. Name 5");

            while (choiceExecute)
            {
                while (numberchoice)
                {
                    int x = 0;
                    Console.Write("which work do you want to execute ? : ");
                    ChooseWork = Console.ReadLine();
                    // convert string input user into a int value
                    if (Int32.TryParse(ChooseWork, out x))
                    {
                        if (x > 0 && x < 6)
                        {
                            ListExecuteWork.Add(x);
                            numberchoice = false;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a correct value.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct value.");
                    }
                }
                
                Console.Write("Execute another work ? (y/n) : ");
                AnotherWork = Console.ReadLine();
                while (ChoiceAnotherWord)
                {
                    if (AnotherWork == "y")
                    {
                        numberchoice = true;
                        break;
                    }
                    else if (AnotherWork == "n")
                    {
                        choiceExecute = false;
                        ChoiceAnotherWord = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct value.");
                        break;
                    }
                }
            }
            // print the list
            /*
            foreach (int i in ListExecuteWork)
            {
                Console.WriteLine(i);
            }
            */
            return ListExecuteWork;
            
            //call the method ExecuteXWork
            //workManager.ExecuteXWork(ChooseWork);
        }
    }
}
