using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseLesson1Task4
{
    class Point
    {
        public Point(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
        private string name = null;
        private int x;
        private int y;

        public string Name { get { return name; } }
        public int X { get { return x; } }
        public int Y { get { return y; } }
    }
}
