using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
   public  class MathPeformedEventArgs:EventArgs
    {
        public double  result { get; set; }

        public MathPeformedEventArgs(double _result)
        {
            result = _result;
        }


    }
}
