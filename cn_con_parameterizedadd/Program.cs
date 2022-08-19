using System;
namespace Constructor
{
    class paraconstrctor
    {
        public int a, b,s;
        
        public paraconstrctor(int x, int y)  // decalaring Paremetrized Constructor with ing x,y parameter
        {
            a = x;
            b = y;
            s = a + b;
           
        }
        public double c, d,e;

        public paraconstrctor(double x, double y)  // decalaring Paremetrized Constructor with ing x,y parameter
        {
            c = x;
            d = y;
            e = c + d;

        }

    }

   
    class MainClass
    {
        static void Main()
        {
            paraconstrctor v = new paraconstrctor(100, 175);   
            Console.WriteLine("sum= {0}",v.s);
            paraconstrctor v1 = new paraconstrctor(100.65, 175.78);  
            Console.WriteLine("sum= {0}", v1.e);
            Console.Read();
        }
    }
}