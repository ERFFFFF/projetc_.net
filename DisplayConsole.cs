using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.net
{
    class DisplayConsole : IDisplay
    {
        internal class Work
        {
            public string name { get; set; }
            public string sourcePath { get; set; }
            public string targetPath { get; set; }
            public string saveType { get; set; }
            public int saveNumber { get; set; }
            
        }

       // WorkManager workManager = new WorkManager();

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
        public Work DisplayCreateNewWork()
        {
            Work works = new Work
            {
                name = "",
                sourcePath = "",
                targetPath = "",
                saveType = "",
                saveNumber = 0
            };
            // function majuscule
            string name = "Name of your work : ";
            works.name = loop(name);

            string saveType = "Mirror save or Diferential save ? : ";
            works.saveType = loop(saveType);

            String sourcePath = "Source Directory of your work : ";
            works.sourcePath = loop(sourcePath);

            string targetPath = "Targeted Directory of your the work : ";
            works.targetPath = loop(targetPath);

            if (works.saveType != "Mirror" && works.saveType != "Differential")
            {
                Console.WriteLine("Please enter a correct value. ddddd");
            }
            return works;
        }
        public string loop(string consoleLog)
        {
            string checkEmpty;
            do
            {
                Console.Write(consoleLog);
                checkEmpty = Console.ReadLine();
                if (checkEmpty == "")
                {
                    Console.WriteLine("Please enter a correct value.");
                }

            } while (string.IsNullOrEmpty(checkEmpty));
            return checkEmpty;
        }
        public List<int> DisplayExecuteXWork()
        {
            List<int> ListExecuteWork = new List<int>();
            string ChooseWork;
            string AnotherWork;
            bool choiceExecute = true;
            bool numberchoice = true;
            bool ChoiceAnotherWork = true;
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
                while (ChoiceAnotherWork)
                {
                    if (AnotherWork == "y")
                    {
                        numberchoice = true;
                        break;
                    }
                    else if (AnotherWork == "n")
                    {
                        choiceExecute = false;
                        ChoiceAnotherWork = false;
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
