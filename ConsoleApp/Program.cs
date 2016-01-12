using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public static bool Method1()
        {
            Console.WriteLine("Method1");
            return true;
        }

        public static bool Method2()
        {
            Console.WriteLine("Method2");
            return false;
        }

        static void Meth3(int a)
        {
            Console.WriteLine("Method");
            if (a > 2) { 
                Meth3(a);
                a--;
            }
        }
        static void Main(string[] args)
        {
            int n = 7;
            int l = 0;

            for (var i = 0; i < n; i++)
            { //проганяєм 7 раз цикл


                for (var k = 0; k < (2 * n / 2 - i); k++)
                {
                    Console.Write("\t");
                }

                for (var j = 0; j < l; j++)
                {
                    Console.Write("\t *");

                }
                l++;

                Console.WriteLine();

            }
            

        }
    }
}
