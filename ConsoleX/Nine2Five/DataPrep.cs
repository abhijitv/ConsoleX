using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleX
{
    public static class DataPrep
    {
       static List<WebsiteDataModel> lstWebsiteModels;
        /// <summary>
        /// create the list of URls to be downloaded   by opening a text file and getting all the links from 
        /// there 
        /// </summary>
        public  static void BuildURLList(string path)
        {

            // variables declaration 
            int counter = 0;
            string line;

            // get the file path 
            if (path.Count() == 0) path = "C:\\Abhi\\Dev\\C#\\ConsoleX\\ConsoleX\\ListURL.txt";

            // open the file 
            System.IO.StreamReader file = new StreamReader("C:\\Abhi\\Dev\\C#\\ConsoleX\\ConsoleX\\ListURL.txt");
            while ((line =file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }
            Console.ReadLine();

            //lstWebsiteModels = new List<WebsiteDataModel>();

        }



        
    }
}
