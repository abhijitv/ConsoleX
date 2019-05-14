


namespace ConsoleX
{
    public class Math
    {

        // declare a delegate 

      
        public delegate void PostTaskDelegate(double results);
     
        public PostTaskDelegate postDlg;

        // initialize the delegate in constructor 


        public Math()
        {

        }

        public void Add(int x, int y)
        {

            double sum = x + y;
            postDlg(sum);
        }

       public  void Multiply(int x, int y)

        {
            double product = x * y;
            postDlg(product);

        }

     

    }
}
