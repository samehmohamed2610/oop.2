using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal struct Point
    {
        //fields
        private int x;
        private int y;

        //Constructor
        public Point( int x , int y) 
        {
            this.x = x;
            this.y = y;
        }
        //Methods
        public override string ToString()
        {
            return $"({x} , {y})";
        }

    }
}
