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
                    MathSvc MSvc = new MathSvc(OperationType.DelegateOnly);
                    
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
                    string path = "";
                    DataPrep.BuildURLList(path);
                    break;
                      
               
            }

           
}
