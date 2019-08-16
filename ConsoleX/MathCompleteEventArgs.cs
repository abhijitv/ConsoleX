using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
    public class MathCompleteEventArgs:EventArgs
    {

      public  double result;
        public MathCompleteEventArgs(double number )
        {
            result = number;
        }
        
    }
}
