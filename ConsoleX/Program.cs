using System;
namespace ConsoleX

{
    class Program
    {
        static MathSvc4Delegate mathSvc4Delegate;
        static string x;
        static string y;
        static MathSvc4Event mathSvc4Event;
        static MathSvc4Action mathSvc4Action;
        static void Main(string[] args)
        {

            Console.WriteLine("Please make your choice");
            Console.WriteLine("1. Pure Delegates");
            Console.WriteLine("2. Events");
            Console.WriteLine("3. Actions");


            switch (Convert.ToInt32(Console.ReadLine()))
            {

                case 1: // use only delegates 
                   
                    GetInputs();
                    Domath(Convert.ToInt32(x), Convert.ToInt32(y));
                    break;

                case 2://using events instead of delegates 
                  
                    GetInputs();
                    DoMath4Event(Convert.ToInt32(x), Convert.ToInt32(y));
                    break;
                case 3: // use actions instead of events and delegates 
                    GetInputs();
                    DoMath4Action(Convert.ToInt32(x), Convert.ToInt32(y));
                    break;

                default:
                    break;
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
                 x = Console.ReadLine();
                Console.WriteLine("enter the second number");
                y = Console.ReadLine();

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
