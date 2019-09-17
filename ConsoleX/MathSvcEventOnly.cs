using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
    public class MathSvcEventOnly
    {

        public event EventHandler<MathPerformedEventArgs> MathPerofrmedEvent;

      public  void AddNumbers(double x, double y)
        {
            double result = x + y;
            MathPerofrmedEvent(this, new MathPerformedEventArgs(result));

        }

    }
}
