using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
    class MathSvcAction
    {
        public Action<double> MathPerformed;

        public void AddNumbers(double x, double y)
        {

            double result = x + y;
            MathPerformed(result);

        }


    }
}
