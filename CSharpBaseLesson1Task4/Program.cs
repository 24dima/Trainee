using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseLesson1Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure frigure = new Figure(new Point("A",1,1), new Point("B", 1,4), new Point("C", 4,4));
            Console.WriteLine("Type figure {0}, P = ", frigure.Type);
            frigure.PerimeterCalculator();
        }
    }
}
