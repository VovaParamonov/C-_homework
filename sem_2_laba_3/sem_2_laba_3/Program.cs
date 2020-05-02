using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem_2_laba_3
{
    public class Program1
    {
        public delegate double myDelegate(int[] a);

        static public myDelegate calculate = delegate (int[] a)
        {
            double sum = 0;
            foreach (int elem in a)
            {
                sum += elem;
            }
            return sum / a.Length;
        };

        static void Main1(string[] args)
        { 
            int[] array = { 1, 1, 2, 2 };
            //Console.WriteLine(Program1.calculate(array));
            Console.ReadKey();
        }
    }

    public class Program2
    {
        public delegate double MyDelegate(double x, double y, string oper);

        static public MyDelegate calculate = (x, y, oper) =>
        {
            switch (oper)
            {
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                default: throw new Exception();
            }
        };

        public static void Main(string[] args)
        {
            Console.WriteLine(calculate(1, 1, Console.ReadLine()));

            Console.ReadKey();
        }
    }
}
