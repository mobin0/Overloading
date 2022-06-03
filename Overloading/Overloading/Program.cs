using System;

namespace Overloading
{
    internal class Program
    {
        public static int Add(int a, int b) {
            return a + b;
        
        }

        public static double Add(double a, double b)
        {


            return a + b;

        }

        public static string Add(int a, int b, bool c)
        {
            int result = a + b;
            if (c) {
                return result +"$";
            }
            return "{a+b}";

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.11, 2.22));
            Console.WriteLine(Add(1,1,true));
            Console.WriteLine("Add Overloading Complete");
        }
    }
}
