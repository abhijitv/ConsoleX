using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
    public enum  OperationType
    {
                        
        DelegateOnly,       // Use only delegates 
        EventOnly,          // use events instead of delegates 
        ActionOnly,         // use actions instead of events and delegates 
        AnonymousOnly,      // use anonymous methods 
        AsyncOnly           // use  async action 

    }
    public class MathSvc
    {
        async Task DoProcess()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await ProcessDownloads();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds / 1000);


        }
        public MathSvc(OperationType opnType)
        {

        }



        async Task ProcessDownloads()
        {
            List<Task<string>> lstTasksDataModel = new List<Task<string>>();
            foreach (WebsiteDataModel wsm in lstWebsiteModels)
            {
                lstTasksDataModel.Add(Task.Run(() => DownloadURL(wsm.WebsiteURL)));

            }
            var results = await Task.WhenAll(lstTasksDataModel);

        }

        string DownloadURL(string URL)
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

        public void GetInputs()
        {

            Console.WriteLine("Enter the first  number");
           int  x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
           int  y = Convert.ToInt32(Console.ReadLine());

        }



       public  void Domath(int x, int y)
        {
            // define and assign the delegate 
            MathSvc4Delegate mathSvc4Delegate = new MathSvc4Delegate();
            mathSvc4Delegate.MathComplete = PublishResults;
            
            // do the math operation 
            mathSvc4Delegate.Add(x, y);

        }

         public void DoMath4Event(int x, int y)

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
}
