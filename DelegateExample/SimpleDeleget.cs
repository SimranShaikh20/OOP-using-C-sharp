using System;

namespace DelegateExample
{
   
    delegate int MathOperation(int a, int b);

    public class SimpleDelegat
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
