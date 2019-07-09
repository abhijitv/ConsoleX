using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleX
{
    public class MathSvc4Event
    {

        public event EventHandler<MathPeformedEventArgs> MathPerformed;
    
     public   void Add(double x, double y)
        {

            double result = x + y;
            MathPerformed(this,new MathPeformedEventArgs(result));

        }
       public void Multiply(double x, double y)
        {
            double result = x * y;
        }


    }

}
