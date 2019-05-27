using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
    class Logger : IMathPerformed
    {


        public Logger()
        {

        }


        public void LogEvent(object sender, MathPerformedEventArgs e)
        {

            Console.WriteLine("Event log -" + e.Results);
            //throw new NotImplementedException();
        }

        public void Printvent(object sender, MathPerformedEventArgs e)
        {
            Console.WriteLine("Print to Console -" + e.Results);
            Console.ReadLine();
            //throw new NotImplementedException();
        }
    }
}
