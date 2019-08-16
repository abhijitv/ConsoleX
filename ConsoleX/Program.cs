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
        EventNDelegate,
        Action,
        None
    }

    class Program
    {
        static OperationType opnType = OperationType.None;
        

       static  double x, y;
        public static void Main()
        {
            while (true)
           {

                GetInputs();  // Get inputs from screen 

                CallMathService();  // call the proper service 

            }
        }

        

        public static void   GetInputs()
        {
            // get the first number 
            Console.WriteLine("Hello World! Please enter a number");
            Double  number;
            
            while( !double.TryParse(Console.ReadLine(),out  number))
            {
                Console.WriteLine("Please enter a valid numerical value");
                Console.WriteLine("Please enter a number");
                
            }
            x = number;
            // get the second number 
            Console.WriteLine("Please enter another number");
            while (!double.TryParse(Console.ReadLine(), out number))
        
            {
                Console.WriteLine("please enter a valid numerical value");
                Console.WriteLine("please enter a number");
            }

            y = number;

            // get the operation type 
            int opnTypeVal;
            Console.WriteLine("please enter an operation type");
            Console.WriteLine("o- Delegate only, 1-Event Only, 2-Delegate and Event, 3-Actions, 4 -Async");
            while (!int.TryParse(Console.ReadLine(), out opnTypeVal))
            {
                Console.WriteLine("Please enter a valid numerical value");
                Console.WriteLine("Please enter a  number");
            }

            opnType = (OperationType)opnTypeVal;

        }

        public static  void CallMathService()
        {
           
            // call the right function  
            switch (opnType)
            {
                case OperationType.DelegateOnly:
                    var mathSvcDlgOnly = new MathSvcDlgOnly();
                    // assign the delegate  
                    mathSvcDlgOnly.MathCompleteDlg = PublishResults;
                    mathSvcDlgOnly.AddNumbers(x, y);
                    break;
                case OperationType.EventOnly:
                  

                    break;
                case OperationType.EventNDelegate:
                    var mathSvcEventNDelegate = new MathSvcEventNDelegate();
                    mathSvcEventNDelegate.MathPeformed+= PublishResults;
                    mathSvcEventNDelegate.AddNumbers(x, y);
                    break;
                case OperationType.Action:
                    break;
                case OperationType.None:
                    break;
                default:
                    break;
            }
          
        }


     public static void PublishResults(double result)
        {
            Console.WriteLine("The result of the operation is " + result);
           
        }

        public static void MathCompleteOperation( object sender, EventArgs e)
        {
           // Console.WriteLine("The result of the operation is " + e.);
          
        }

    }


}
