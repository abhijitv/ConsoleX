using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleX
{
    public interface IMathPerformed
    {

        void LogEvent(object sendder, MathPerformedEventArgs e);
        void Printvent(object sneder, MathPerformedEventArgs e);

       

    }
}
