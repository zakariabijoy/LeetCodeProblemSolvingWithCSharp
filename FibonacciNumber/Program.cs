using System;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Fib(2);
        }

        public static int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Fib(n - 1) + Fib(n - 2);

        }
       
    }
}
