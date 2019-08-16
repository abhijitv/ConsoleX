using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
    public class MathSvcEventNDelegate
    {

        public delegate void MathPerformedDlg(double rsult);
        public event MathPerformedDlg MathPeformed;

        public void AddNumbers(double x, double y)
        {
            double result = x + y;
            MathPeformed(result);
        }

    }
}
