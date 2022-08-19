using System;

namespace cn_con_clas
{
    class Cube
    {
        public double side;

    }

    class Cubearea
    {
        static void Main(string[] args)
        {
            Cube c1 = new Cube();
            c1.side = 4.56;
            double area = c1.side * c1.side * c1.side;
            Console.WriteLine(area);
        }
    }
}
