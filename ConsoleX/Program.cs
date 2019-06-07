using System;
using System.Collections.Generic;
using System.Web;

namespace ConsoleX

{
    class Program
    {
        static MathSvc4Delegate mathSvc4Delegate;
        static   int x;
        static  int y;
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
                    int result=0;
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
                    break;
                default:
                    break;
            }


            void PrepData()
            {
                List<string> lstURLs = new List<string>();
                lstURLs.Add("www.google.com");
                lstURLs.Add("www.yelp.com");
                lstURLs.Add("www.amazon.com");
                lstURLs.Add("www.microsoft.com");
                lstURLs.Add("www.spekify.com");
            }
          
            void ProcessDownloadOperation()
            {

                WebsiteDataModel websitemodel = new WebsiteDataModel();


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

       static void PublishResults4Event(object sender,MathPeformedEventArgs e)
        {

            Console.WriteLine(e.result);
            Console.ReadLine();
        }
    }
}
