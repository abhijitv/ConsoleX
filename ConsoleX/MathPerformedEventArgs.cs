using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
    public class MathPerformedEventArgs:EventArgs
    {

        public double result { get; set; }
        public MathPerformedEventArgs(double number)
        {
            result = number;
        }
        
    }
}
