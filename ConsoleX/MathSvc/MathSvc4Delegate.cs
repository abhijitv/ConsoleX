using System;


namespace ConsoleX
{
    public class MathSvc4Delegate
    {

         public delegate void MathCompleteEventHandler( double sum);
        public Func<int, int, double> DoSoneOperation;

         public MathCompleteEventHandler MathComplete ;

        public MathSvc4Delegate()
        {
            
        }

        public void Add(int x, int y)
        {
            double sum = x + y;
            MathComplete(sum);
        }

       public  void Multiply(int x, int y)

        {
            double product = x * y;
            MathComplete(product);

        }
        
     

    }
}
