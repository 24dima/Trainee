using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double side1, side2;

            Console.Beep();
            Console.WriteLine("Введіть сторону а:");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть сторону b:");
            side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle myRec = new Rectangle(side1, side2);
            Console.WriteLine("Area {0}, Perymetr {1}", myRec.AreaCalculator(), myRec.PerimeterCalculator());

        }

        private class Adress
        {
            private int index = 0;
            private string country = null;
            private string city = null;
            private string street = null;
            private string house = null;
            private string apartament = null;

            public int Index
            {
                get { return index; }
                set { index = value; }
            }

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            public string Street
            {
                get { return street; }
                set { street = value; }
            }

            public string House
            {
                get { return house; }
                set { house = value; }
            }

            public string Apartament
            {
                get { return apartament; }
                set { apartament = value; }
            }


        }
    }
}