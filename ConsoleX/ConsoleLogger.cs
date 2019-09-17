using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
  public  class ConsoleLogger : IMathPeformed

    {
        public void ONMathPerformed(object sneder, MathPerformedEventArgs args)
        {
            Console.WriteLine(" the result from interface  is " + args.result);
        }


    }

}
