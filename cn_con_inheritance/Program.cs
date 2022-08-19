using System;

namespace cn_con_inheritance
{
    public class A
    {
        private int _value = 10;

        public class B : A
        {
            static B()
            {
                 Console.WriteLine("Static constructor of derived class (B) invoked");
            }
    
            public int GetValue()
            {
                return _value;
            }

        }
    }
   

    public class AccessExample
    {
        public static void Main(string[] args)
        {
            var b = new A.B();
            Console.WriteLine(b.GetValue());
        }
    }
}
