using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleX
{
    public class MathSvc4Event
    {
        public EventHandler MathperfEventHandler;
        public event MathperfEventHandler MathPerformed;
       

        void Add(double x, double y)
        {

            double result = x + y;
            MathPerformed(this,new MathPeformedEventArgs(result));

        }
        void Multiply(double x, double y)
        {
            double result = x * y;
        }


    }

}
