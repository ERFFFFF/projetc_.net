using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projet.net
{
    class WorkManager
    {
        internal class Work
        {
            public string name { get; set; }
            public string sourcePath { get; set; }
            public string targetPath { get; set; }
            public string saveType { get; set; }
            public int saveNumber { get; set; }

        }
        Work works = new Work
        {
            name = "qsd",
            sourcePath = "qsd",
            targetPath = "qsd",
            saveType = "qsdqsd",
            saveNumber = 0
        };

        public void createNewWork(Work work)
        {
            // nombres de charactere max, path exist ou aps
            if (works.name.Length >= 24)
            {
                Console.WriteLine("Name : " + works.name);
                // write data in a .txt file
            }
            else
            {
                Console.WriteLine("Please enter a correct lengths name (max 24 characters).");
            }
            if (Directory.Exists(works.sourcePath))
            {
                Console.WriteLine("sourcepath : " + works.sourcePath);
                // write data in a .txt file
            }
            else
            {
                Console.WriteLine("Please enter a correct source path.");
            }
            if(Directory.Exists(works.targetPath))
            {
                Console.WriteLine("targetpath : " + works.targetPath);
                // write data in a .txt file
            }
            else
            {
                Console.WriteLine("Please enter a correct target path.");
            }
        }
        public void ExecuteXWork(string chooseWork)
        {
            Console.WriteLine($"You choose to execute the work number {chooseWork}");
            
            //idk what to do next
        }
    }
}
