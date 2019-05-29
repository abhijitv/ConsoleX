using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
       public class MathSvc4Action
    {

        public Action<Double> MathPerformed;
       public  void AddNumbers( int x, int y)
        {
            double result = x + y;
            MathPerformed(result);
        }
    }
}
