using System;


namespace ConsoleX
{
    public class Math
    {

        // declare a delegate 


        //public delegate void MathCompleteEventHandler( double sum);

        //public event MathCompleteEventHandler MathComplete ;


        public event EventHandler<MathPerformedEventArgs> MathComplete;



        public Math()
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
