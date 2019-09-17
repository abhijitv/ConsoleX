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
        Interface,
        None
    }

    class Program
    {
        static OperationType opnType = OperationType.None;

        static List<int> custlst;

        static double x, y;
        public static void Main()
        {


            while (true)
            {

                GetInputs();  // Get inputs from screen 

                CallMathService();  // call the proper service 

            }
        }



        public static void GetInputs()
        {
            // get the first number 
            Console.WriteLine("Hello World! Please enter a number");
            Double number;

            while (!double.TryParse(Console.ReadLine(), out number))
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
            Console.WriteLine("o- Delegate only, 1-Event Only, 2-Delegate and Event, 3-Actions, 4 -Interface, 5- None");
            while (!int.TryParse(Console.ReadLine(), out opnTypeVal))
            {
                Console.WriteLine("Please enter a valid numerical value");
                Console.WriteLine("Please enter a  number");
            }

            opnType = (OperationType)opnTypeVal;

        }

        public static void CallMathService()
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
                    var mathSvcEventOnly = new MathSvcEventOnly();
                    mathSvcEventOnly.MathPerofrmedEvent += PublishResultsEvent;
                    mathSvcEventOnly.AddNumbers(x, y);

                    break;
                case OperationType.EventNDelegate:
                    var mathSvcEventNDelegate = new MathSvcEventNDelegate();
                    mathSvcEventNDelegate.MathPeformedEvent += PublishResults;
                    mathSvcEventNDelegate.AddNumbers(x, y);
                    break;
                case OperationType.Action:
                    var MathSvcAction = new MathSvcAction();
                    MathSvcAction.MathPerformed += PublishResults;
                    MathSvcAction.AddNumbers(x, y);

                    break;
                case OperationType.Interface:
                    var mathSvcInterface = new MathSvcEventOnly();
                    IMathPeformed consoleLogger = new ConsoleLogger();
                    mathSvcInterface.MathPerofrmedEvent += consoleLogger.ONMathPerformed;
                    mathSvcInterface.AddNumbers(x, y);
                    break;
                default:
                    // implementation of binary search 

                    int[] arrNumbers = new int[] { 2, 3, 4, 5, 12, 90, 900 };
                    int ind=BinaqrySearch(900,arrNumbers);
                    Console.WriteLine(ind);
                    break;
            }

        }

        static int BinaqrySearch(int i, int[] arrNum)
        {
            int left = 0;
            int  right = arrNum.Length - 1;
            Array.Sort(arrNum);

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (arrNum[middle] == i) return middle;
                else if (i>=arrNum[middle])
                {
                    left = middle + 1;
                }
                else 
                {
                    right = middle - 1;
                }

            }
            return 0;
        }

      static  bool iSenglishLetter( char ch)
        {
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                return true;
            }
            else return false;
        }

        static  bool  IsNumber( char ch)
        {

            if (Convert.ToInt32(ch) >= 0 && Convert.ToInt32(ch) <= 9)
            {
                return true;
            }
            else return false;

        }
    
        public static void PublishResultsEvent(object sender, MathPerformedEventArgs args)
        {
            Console.WriteLine("The result is " + args.result);

        }
        public static void PublishResults(double result)
        {
            Console.WriteLine("The result of the operation is " + result);

        }

        public static void MathCompleteOperation(object sender, EventArgs e)
        {
            // Console.WriteLine("The result of the operation is " + e.);

        }

    }


}
