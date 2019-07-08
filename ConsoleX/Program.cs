using System;
using System.Collections.Generic;
using System.Web;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleX

{
    class Program
    {
        static MathSvc4Delegate mathSvc4Delegate;
        static int x;
        static int y;
        static MathSvc4Event mathSvc4Event;
        static MathSvc4Action mathSvc4Action;
        
         static void Main(string[] args)
        {

            Console.WriteLine("Please make your choice");
            Console.WriteLine("1. Pure Delegates");
            Console.WriteLine("2. Events");
            Console.WriteLine("3. Actions");
            Console.WriteLine("4. Lambda ");
            Console.WriteLine("5. Async Download");

            switch (Convert.ToInt32(Console.ReadLine()))
            {


                case 1: // use only delegates 
                    GetInputs();
                    Domath(x, y);
                    break;

                case 2://using events instead of delegates 
                    GetInputs();
                    DoMath4Event(x, y);
                    break;
                case 3: // use actions instead of events and delegates 
                    GetInputs();
                    DoMath4Action(x, y);
                    break;

                case 4: // when the delegate class does not know anything about its being asked to do 
                    GetInputs();
                    mathSvc4Delegate = new MathSvc4Delegate();
                    int result = 0;
                    mathSvc4Delegate.DoSoneOperation += (x, y) =>
                     {
                         result = x + y;
                         return result;
                     };
                    mathSvc4Delegate.DoSoneOperation(x, y);
                    Console.WriteLine(result);
                    Console.ReadLine();
                    break;

                case 5: // download some websites automatically 
                    PrepData();
                    DoProcess();
                    Console.ReadLine();
                    break;
                case 6: // Do the data  crunching 
                    PrepData();  // prepare the  URLs that need to be downloaded 
                default:
                    break;
            }

            async Task DoProcess()
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                await ProcessDownloads();
                watch.Stop();
                Console.WriteLine(watch.ElapsedMilliseconds/1000);


            }

            

           async  Task  ProcessDownloads()
            {
                List<Task<string>> lstTasksDataModel = new List<Task<string>>();
                foreach ( WebsiteDataModel wsm in lstWebsiteModels)
                {
                    lstTasksDataModel.Add(Task.Run(() => DownloadURL(wsm.WebsiteURL)));
                    
                }
                var results = await Task.WhenAll(lstTasksDataModel);

            }

            string  DownloadURL (string URL )
            {
                // here goes the code for actual download of the URL 
                WebClient wc = new WebClient();
                Console.WriteLine("Downloading " + URL);
                return (wc.DownloadString(URL));
               
            }



            void DoMath4Action(int x, int y)
            {
                mathSvc4Action = new MathSvc4Action();
                mathSvc4Action.MathPerformed += PublishResults;

                mathSvc4Action.AddNumbers(x, y);

            }
            void GetInputs()
            {

                Console.WriteLine("Enter the first  number");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second number");
                y = Convert.ToInt32(Console.ReadLine());

            }

        }

        static void Domath(int x, int y)
        {
            mathSvc4Delegate = new MathSvc4Delegate();
            mathSvc4Delegate.MathComplete = PublishResults;

            mathSvc4Delegate.Add(x, y);

        }

        static void DoMath4Event(int x, int y)

        {
            mathSvc4Event = new MathSvc4Event();
            mathSvc4Event.MathPerformed += PublishResults4Event;
            mathSvc4Event.Add(x, y);
        }

        static void PublishResults(double result)
        {
            Console.WriteLine(result);
            Console.ReadLine();

        }

        static void PublishResults4Event(object sender, MathPeformedEventArgs e)
        {

            Console.WriteLine(e.result);
            Console.ReadLine();
        }
    }
}
