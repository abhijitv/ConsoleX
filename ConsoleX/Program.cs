using System;
namespace ConsoleX

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first  number");
            string x = Console.ReadLine();
            Console.WriteLine("enter the second number");
            string y = Console.ReadLine();
            Domath(Convert.ToInt32(x), Convert.ToInt32(12));

        }

      static   void Domath(int x, int y)
        {

            Math math = new Math();

            math.postDlg = PublishResults;
            math.Add(x, y);
        

        }

        static  void PublishResults(double results)
        {
            Console.WriteLine(results);
            Console.ReadLine();

        }
    }
}
