using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleX
{
    public class MathSvcDlgOnly:ImathSvc
    {

        // Local variable for operation type 
        OperationType opnType;

        // variables for delegate only 
        public delegate void MathComplete(double result); // delegate declaration 
        public MathComplete MathCompleteDlg; // delegate that will be assigned the function at run time 


        public void AddNumbers(double x, double y)
        {
            // do the addition 
            double sum = x + y;

            // Call the delegate 
            MathCompleteDlg(sum);

        }
    }
}
