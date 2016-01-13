using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adress myAdress = new Adress();
            //myAdress.City = "Lviv";
            //myAdress.Country = "Ukraine";
            //myAdress.House = "43A";
            //myAdress.Street = "Shyroka";

            //Console.WriteLine("City: {0}, country: {1}, house: {2}, street: {3}",
            //    myAdress.City, myAdress.Country,myAdress.House, myAdress.Street);
        }
    }

    class Adress
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
