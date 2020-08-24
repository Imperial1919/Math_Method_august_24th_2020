using System;
using System.ComponentModel;

namespace Math_Method_august_24th_2020
{
    class Program
    {

        static void Main(string[] args)
        {




            var result = Add(20, 20);
            Console.WriteLine(result);

            var result_mutiply = Mult(20, 20);
            Console.WriteLine(result_mutiply);

        }


        public static int Add(int a, int b)
        {
            return a + b;
        }
        
    

        public static int Mult(int c, int d)
        {
            return c * d;
        }
       
    }
}
