using System;
namespace ConsoleX

{
    class Program
    {
        static MathSvc4Delegate mathSvc4Delegate;
        static string x;
        static string y;
        static void Main(string[] args)
        {

            Console.WriteLine("Please make your choice");
            Console.WriteLine("1. Pure Delegates");
            Console.WriteLine("2. Events");
            Console.WriteLine("3. Actions");


            switch (Convert.ToInt32(Console.ReadLine()))
            {

                case 1: // use only delegates 
                    mathSvc4Delegate = new MathSvc4Delegate();
                    mathSvc4Delegate.MathComplete = PublishResults;
                    GetInputs();
                    Domath(Convert.ToInt32(x), Convert.ToInt32(y));
                    break;

                case 2://using events instead of delegates 
                    MathSvc4Event mathSvc4Event = new MathSvc4Event();
                    mathSvc4Event.MathPerformed+= PublishResults4Event;

                    break;
                case 3:
                    break;

                default:
                    break;
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

            mathSvc4Delegate.Add(x, y);

        }

        static void PublishResults(double result)
        {
            Console.WriteLine(result);
            Console.ReadLine();

        }

       static void PublishResults4Event(object sender,MathPeformedEventArgs e)
        {

            Console.WriteLine(e.);
            Console.ReadLine();


        }
    }
}
