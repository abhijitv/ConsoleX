using System;
using System.Collections.Generic;
using System.Web;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleX

{

    public enum OperationType
    {

        DelegateOnly,
        EventOnly,
        EventDelegate,
        Action
    }

    class Program
    {
        static OperationType opnType;
        static MathService MathSvc;

       static  double x, y;
        public static void Main()
        {
            // Get inputs from screen 
            GetInputs(); // Get the inputs 

            CallMathService();  // call the proper service 
        }

        public static void   GetInputs()
        {

            Console.WriteLine("Hello World! Please enter a number");
            int result;
            while( !int.TryParse(Console.ReadLine(),out result))
            {
                Console.WriteLine("Please enter a valid numerical value");
                Console.WriteLine("Please enter a number");
                
            }
            

        }

        public static  void CallMathService()
        {
            MathSvc = new MathService();

            // assign the delegate  
            MathSvc.MathCompleteDlg = PublishResults;

            // call the right function  
            switch (opnType)
            {
                case OperationType.DelegateOnly:
                    MathSvc.AddNumbersDelegateOnly(x, y);
                    break;
                case OperationType.EventOnly:

                    break;
                case OperationType.EventDelegate:
                    break;
                case OperationType.Action:
                    break;
                default:
                    break;
            }
            
        }


     public   static void PublishResults(double result)
        {
            Console.WriteLine("The result of the operation is " + result);
            GetInputs();
        }

    }


}
