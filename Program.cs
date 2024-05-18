using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine(pi);
            int a = 333;
            byte b = 0;
            b = (byte)a;
            Console.WriteLine(b);

            int x = 2, y = 8;
            double z = Math.Pow(x, y);  
            Console.WriteLine(z);
            double xx = Math.Sqrt(z);   
            Console.WriteLine(xx);
            bool res = x != y;
            Console.WriteLine(res); 
            Console.WriteLine(--a);
            Console.WriteLine(++x); 
            Console.WriteLine(--x);

            byte var1 = 253;
            byte var2 = 111;
            byte var3 = (byte)(var1 + var2);  
            Console.WriteLine(var3);
            var2 += 5;
            Console.WriteLine(var2);

            int var11 = 5000;
            int var22 = 5000;
            int var33 = var11 + var22;
            Console.WriteLine(var33);

            sbyte aa = 127;

            unchecked
            {
                aa++;
            }
            Console.WriteLine(aa); 
            Console.WriteLine("Это число {2}, {0}, {1}", 3, 7, 10);
            Console.WriteLine("{0}, {1}", sizeof(int), sizeof(bool));
        }
    }
}
